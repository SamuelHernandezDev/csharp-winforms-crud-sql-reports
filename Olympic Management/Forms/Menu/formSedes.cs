using Olympic_Management.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympic_Management
{
    public partial class formSedes : Form
    {
        private DatabaseConnection dbConnection;

        public formSedes()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection(); // Crear instancia de conexión a la base de datos
        }

        private void formSedes_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            SetupDataGridView(); // Configurar columnas del DataGridView
            LoadData(); // Cargar datos de la base de datos
        }

        // Configuración del DataGridView para reflejar la estructura de la tabla Sede
        private void SetupDataGridView()
        {
            dgvSedes.Columns.Clear();
            dgvSedes.Columns.Add("ID_sede", "ID");
            dgvSedes.Columns.Add("Nombre", "Nombre de la Sede");
            dgvSedes.Columns.Add("Numero_complejos", "Número de Complejos");
            dgvSedes.Columns.Add("Presupuesto_aproximado", "Presupuesto Aproximado");
            dgvSedes.Columns["ID_sede"].Visible = false; // Ocultar columna de ID en la vista
            dgvSedes.Columns["Presupuesto_aproximado"].DefaultCellStyle.Format = "C2"; // Formato de moneda con dos decimales
        }

        // Método para cargar datos de la base de datos
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Sede";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                dgvSedes.Rows.Clear();
                while (reader.Read())
                {
                    dgvSedes.Rows.Add(reader["ID_sede"].ToString(), reader["Nombre"].ToString(), reader["Numero_complejos"].ToString(), reader["Presupuesto_aproximado"].ToString());
                }

                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y el uso de backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreSede.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroComplejos.Text) ||
                string.IsNullOrWhiteSpace(txtPresupuesto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que el presupuesto es un número decimal positivo
            if (!decimal.TryParse(txtPresupuesto.Text, out decimal presupuesto) || presupuesto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor de presupuesto válido y positivo.");
                return;
            }

            // Insertar datos en la base de datos
            try
            {
                string nombre = txtNombreSede.Text;
                int numeroComplejos = int.Parse(txtNumeroComplejos.Text);

                string query = "INSERT INTO Sede (Nombre, Numero_complejos, Presupuesto_aproximado) VALUES (@nombre, @numeroComplejos, @presupuesto)";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@numeroComplejos", numeroComplejos);
                command.Parameters.AddWithValue("@presupuesto", presupuesto);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Sede agregada exitosamente.");
                LoadData(); // Recargar datos para mostrar el nuevo registro
                ClearFields(); // Limpiar los campos de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sede: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvSedes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sede para editar.");
                return;
            }

            // Cargar los datos de la fila seleccionada en los TextBox
            DataGridViewRow row = dgvSedes.SelectedRows[0];
            txtNombreSede.Text = row.Cells["Nombre"].Value.ToString();
            txtNumeroComplejos.Text = row.Cells["Numero_complejos"].Value.ToString();
            txtPresupuesto.Text = row.Cells["Presupuesto_aproximado"].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvSedes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sede para guardar.");
                return;
            }

            // Obtener el ID desde el DataGridView
            int id = int.Parse(dgvSedes.SelectedRows[0].Cells["ID_sede"].Value.ToString());

            // Validar que el presupuesto es un número decimal positivo
            if (!decimal.TryParse(txtPresupuesto.Text, out decimal presupuesto) || presupuesto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor de presupuesto válido y positivo.");
                return;
            }

            try
            {
                string nombre = txtNombreSede.Text;
                int numeroComplejos = int.Parse(txtNumeroComplejos.Text);

                string query = "UPDATE Sede SET Nombre = @nombre, Numero_complejos = @numeroComplejos, Presupuesto_aproximado = @presupuesto WHERE ID_sede = @id";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@numeroComplejos", numeroComplejos);
                command.Parameters.AddWithValue("@presupuesto", presupuesto);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Sede actualizada exitosamente.");
                LoadData(); // Recargar datos para mostrar el cambio
                ClearFields(); // Limpiar los campos de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la sede: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvSedes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una sede para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar esta sede?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Obtener el ID desde el DataGridView
                    int id = int.Parse(dgvSedes.SelectedRows[0].Cells["ID_sede"].Value.ToString());

                    string query = "DELETE FROM Sede WHERE ID_sede = @id";
                    SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    dbConnection.CloseConnection();
                    MessageBox.Show("Sede eliminada exitosamente.");
                    LoadData(); // Recargar datos después de la eliminación
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la sede: " + ex.Message);
                }
            }
        }

        // Método para limpiar los campos de entrada
        private void ClearFields()
        {
            txtNombreSede.Text = "";
            txtNumeroComplejos.Text = "";
            txtPresupuesto.Text = "";
        }
    }
}



