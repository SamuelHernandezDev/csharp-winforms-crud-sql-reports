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
    public partial class formEquipamiento : Form
    {
        private DatabaseConnection dbConnection;

        public formEquipamiento()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection(); // Crear instancia de conexión a la base de datos
        }

        private void formEquipamiento_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            SetupDataGridView(); // Configurar columnas del DataGridView
            LoadData(); // Cargar datos de la base de datos
        }

        // Configuración del DataGridView para reflejar la estructura de la tabla Equipamiento
        private void SetupDataGridView()
        {
            dgvEquipamiento.Columns.Clear();
            dgvEquipamiento.Columns.Add("ID_equipamiento", "ID");
            dgvEquipamiento.Columns.Add("Nombre", "Nombre del Equipamiento");
            dgvEquipamiento.Columns["ID_equipamiento"].Visible = false; // Ocultar columna de ID en la vista
        }

        // Método para cargar datos de la base de datos
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Equipamiento";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                dgvEquipamiento.Rows.Clear();
                while (reader.Read())
                {
                    dgvEquipamiento.Rows.Add(reader["ID_equipamiento"].ToString(), reader["Nombre"].ToString());
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
            if (string.IsNullOrWhiteSpace(txtNombreEquipamiento.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del equipamiento.");
                return;
            }

            // Insertar datos en la base de datos
            try
            {
                string nombre = txtNombreEquipamiento.Text;

                string query = "INSERT INTO Equipamiento (Nombre) VALUES (@nombre)";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@nombre", nombre);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Equipamiento agregado exitosamente.");
                LoadData(); // Recargar datos para mostrar el nuevo registro
                ClearFields(); // Limpiar el campo de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el equipamiento: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvEquipamiento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un equipamiento para editar.");
                return;
            }

            // Cargar los datos de la fila seleccionada en el TextBox para edición
            DataGridViewRow row = dgvEquipamiento.SelectedRows[0];
            txtNombreEquipamiento.Text = row.Cells["Nombre"].Value.ToString();
            txtNombreEquipamiento.Tag = row.Cells["ID_equipamiento"].Value.ToString(); // Guardar el ID en la propiedad Tag del TextBox
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el campo ID esté presente en Tag
            if (txtNombreEquipamiento.Tag == null)
            {
                MessageBox.Show("Seleccione un equipamiento para guardar cambios.");
                return;
            }

            try
            {
                int id = int.Parse(txtNombreEquipamiento.Tag.ToString());
                string nombre = txtNombreEquipamiento.Text;

                string query = "UPDATE Equipamiento SET Nombre = @nombre WHERE ID_equipamiento = @id";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Equipamiento actualizado exitosamente.");
                LoadData(); // Recargar datos para mostrar el cambio
                ClearFields(); // Limpiar los campos de entrada
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el equipamiento: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvEquipamiento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un equipamiento para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este equipamiento?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Obtener el ID desde el DataGridView
                    int id = int.Parse(dgvEquipamiento.SelectedRows[0].Cells["ID_equipamiento"].Value.ToString());

                    string query = "DELETE FROM Equipamiento WHERE ID_equipamiento = @id";
                    SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    dbConnection.CloseConnection();
                    MessageBox.Show("Equipamiento eliminado exitosamente.");
                    LoadData(); // Recargar datos después de la eliminación
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el equipamiento: " + ex.Message);
                }
            }
        }

        // Método para limpiar los campos de entrada
        private void ClearFields()
        {
            txtNombreEquipamiento.Text = "";
            txtNombreEquipamiento.Tag = null; // Limpiar el ID almacenado en Tag
        }
    }
}

