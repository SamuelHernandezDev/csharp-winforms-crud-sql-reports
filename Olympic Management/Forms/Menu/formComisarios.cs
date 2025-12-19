using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Olympic_Management.Database;
using System.Data.SqlClient;

namespace Olympic_Management
{
    public partial class formComisarios : Form
    {
        private DatabaseConnection dbConnection;

        public formComisarios()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection(); // Crear instancia de conexión a la base de datos
        }

        private void formComisarios_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            SetupDataGridView(); // Configurar columnas del DataGridView
            LoadData(); // Cargar datos de la base de datos
        }

        // Configuración del DataGridView para reflejar la estructura de la tabla Comisario
        private void SetupDataGridView()
        {
            dgvComisarios.Columns.Clear();
            dgvComisarios.Columns.Add("ID_comisario", "ID");
            dgvComisarios.Columns.Add("Nombre", "Nombre del Comisario");
            dgvComisarios.Columns["ID_comisario"].Visible = false; // Ocultar columna de ID en la vista
        }

        // Método para cargar datos de la base de datos
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Comisario";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                dgvComisarios.Rows.Clear();
                while (reader.Read())
                {
                    dgvComisarios.Rows.Add(reader["ID_comisario"].ToString(), reader["Nombre"].ToString());
                }

                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreComisario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del comisario.");
                return;
            }

            // Insertar datos en la base de datos
            try
            {
                string nombre = txtNombreComisario.Text;

                string query = "INSERT INTO Comisario (Nombre) VALUES (@nombre)";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@nombre", nombre);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Comisario agregado exitosamente.");
                LoadData(); // Recargar datos para mostrar el nuevo registro
                ClearFields(); // Limpiar el campo de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el comisario: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvComisarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un comisario para editar.");
                return;
            }

            // Cargar los datos de la fila seleccionada en el TextBox para edición
            DataGridViewRow row = dgvComisarios.SelectedRows[0];
            txtNombreComisario.Text = row.Cells["Nombre"].Value.ToString();
            txtNombreComisario.Tag = row.Cells["ID_comisario"].Value.ToString(); // Guardar el ID en la propiedad Tag del TextBox
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el campo ID esté presente en Tag
            if (txtNombreComisario.Tag == null)
            {
                MessageBox.Show("Seleccione un comisario para guardar cambios.");
                return;
            }

            try
            {
                int id = int.Parse(txtNombreComisario.Tag.ToString());
                string nombre = txtNombreComisario.Text;

                string query = "UPDATE Comisario SET Nombre = @nombre WHERE ID_comisario = @id";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Comisario actualizado exitosamente.");
                LoadData(); // Recargar datos para mostrar el cambio
                ClearFields(); // Limpiar los campos de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el comisario: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvComisarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un comisario para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este comisario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Obtener el ID desde el DataGridView
                    int id = int.Parse(dgvComisarios.SelectedRows[0].Cells["ID_comisario"].Value.ToString());

                    string query = "DELETE FROM Comisario WHERE ID_comisario = @id";
                    SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    dbConnection.CloseConnection();
                    MessageBox.Show("Comisario eliminado exitosamente.");
                    LoadData(); // Recargar datos después de la eliminación
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el comisario: " + ex.Message);
                }
            }
        }

        // Método para limpiar los campos de entrada
        private void ClearFields()
        {
            txtNombreComisario.Text = "";
            txtNombreComisario.Tag = null; // Limpiar el ID almacenado en Tag
        }
    }
}

