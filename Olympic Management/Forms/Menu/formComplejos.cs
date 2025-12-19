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
using Olympic_Management.Database;

namespace Olympic_Management
{
    public partial class formComplejos : Form
    {
        private DatabaseConnection dbConnection;

        public formComplejos()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection(); // Crear instancia de conexión a la base de datos
        }

        private void formComplejos_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            cmbTipoComplejo.Items.Add("Deporte Único");
            cmbTipoComplejo.Items.Add("Polideportivo");
            cmbTipoComplejo.SelectedIndex = 0; // Opción por defecto
            UpdateFormForSelection(); // Configura la vista para la opción por defecto
            LoadData(); // Cargar datos de la base de datos
        }

        private void cmbTipoComplejo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFormForSelection(); // Actualizar la interfaz según la selección
            LoadData(); // Recargar datos para el tipo de complejo seleccionado
        }

        private void UpdateFormForSelection()
        {
            if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
            {
                lblCampo1.Text = "Ubicación";
                lblCampo2.Text = "Jefe de Organización";
                lblCampo3.Text = "Área Total";
                lblReferencia.Text = "Sede"; // Mostrar "Sede" como referencia
                LoadSedesInComboBox(); // Cargar las sedes en el ComboBox
                txtCampo1.Enabled = true;
                txtCampo2.Enabled = true;
                txtCampo3.Enabled = true;
            }
            else
            {
                lblCampo1.Text = "Deporte";
                lblCampo2.Text = "Indicador de Localización";
                lblCampo3.Text = "";
                lblReferencia.Text = "Complejo"; // Mostrar "Complejo" como referencia
                LoadComplejosInComboBox(); // Cargar los complejos en el ComboBox
                txtCampo1.Enabled = true;
                txtCampo2.Enabled = true;
                txtCampo3.Enabled = false;
            }

            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvComplejos.Columns.Clear();

            if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
            {
                dgvComplejos.Columns.Add("ID_complejo", "ID");
                dgvComplejos.Columns.Add("Ubicacion", "Ubicación");
                dgvComplejos.Columns.Add("JefeOrganizacion", "Jefe de Organización");
                dgvComplejos.Columns.Add("AreaTotal", "Área Total");
                dgvComplejos.Columns["ID_complejo"].Visible = false;
            }
            else
            {
                dgvComplejos.Columns.Add("ID_area", "ID");
                dgvComplejos.Columns.Add("Deporte", "Deporte");
                dgvComplejos.Columns.Add("IndicadorLocalizacion", "Indicador de Localización");
                dgvComplejos.Columns["ID_area"].Visible = false;
            }
        }

        private void LoadData()
        {
            try
            {
                string query;
                if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
                {
                    query = "SELECT ID_complejo, Localizacion, Jefe_organizacion, Area_total FROM Complejo WHERE Tipo_complejo = 'Deporte Unico'";
                    SqlDataReader reader = dbConnection.ExecuteQuery(query);
                    dgvComplejos.Rows.Clear();

                    while (reader.Read())
                    {
                        dgvComplejos.Rows.Add(reader["ID_complejo"].ToString(), reader["Localizacion"].ToString(), reader["Jefe_organizacion"].ToString(), reader["Area_total"].ToString());
                    }
                    reader.Close();
                }
                else
                {
                    query = "SELECT ID_area, Deporte, Indicador_localizacion FROM Complejo_Polideportivo_Area";
                    SqlDataReader reader = dbConnection.ExecuteQuery(query);
                    dgvComplejos.Rows.Clear();

                    while (reader.Read())
                    {
                        dgvComplejos.Rows.Add(reader["ID_area"].ToString(), reader["Deporte"].ToString(), reader["Indicador_localizacion"].ToString());
                    }
                    reader.Close();
                }

                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void LoadSedesInComboBox()
        {
            try
            {
                string query = "SELECT ID_sede, Nombre FROM Sede";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                cmbReferencia.Items.Clear();
                while (reader.Read())
                {
                    cmbReferencia.Items.Add(new ComboBoxItem { Text = reader["Nombre"].ToString(), Value = reader["ID_sede"] });
                }

                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las sedes: " + ex.Message);
            }
        }

        private void LoadComplejosInComboBox()
        {
            try
            {
                string query = "SELECT ID_complejo, Localizacion FROM Complejo WHERE Tipo_complejo = 'Deporte Unico'";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                cmbReferencia.Items.Clear();
                while (reader.Read())
                {
                    cmbReferencia.Items.Add(new ComboBoxItem { Text = reader["Localizacion"].ToString(), Value = reader["ID_complejo"] });
                }

                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los complejos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields() || cmbReferencia.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                string query;
                var selectedReference = (ComboBoxItem)cmbReferencia.SelectedItem;
                int referenceID = (int)selectedReference.Value;

                if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
                {
                    query = "INSERT INTO Complejo (ID_sede, Localizacion, Jefe_organizacion, Area_total, Tipo_complejo) VALUES (@idSede, @localizacion, @jefeOrganizacion, @areaTotal, 'Deporte Unico')";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection()))
                    {
                        command.Parameters.AddWithValue("@idSede", referenceID);
                        command.Parameters.AddWithValue("@localizacion", txtCampo1.Text);
                        command.Parameters.AddWithValue("@jefeOrganizacion", txtCampo2.Text);
                        command.Parameters.AddWithValue("@areaTotal", decimal.Parse(txtCampo3.Text));
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    query = "INSERT INTO Complejo_Polideportivo_Area (ID_complejo, Deporte, Indicador_localizacion) VALUES (@idComplejo, @deporte, @indicadorLocalizacion)";
                    using (SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection()))
                    {
                        command.Parameters.AddWithValue("@idComplejo", referenceID);
                        command.Parameters.AddWithValue("@deporte", txtCampo1.Text);
                        command.Parameters.AddWithValue("@indicadorLocalizacion", txtCampo2.Text);
                        command.ExecuteNonQuery();
                    }
                }

                dbConnection.CloseConnection();
                MessageBox.Show("Complejo agregado exitosamente.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el complejo: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvComplejos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un complejo para editar.");
                return;
            }

            DataGridViewRow row = dgvComplejos.SelectedRows[0];
            if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
            {
                txtCampo1.Text = row.Cells["Ubicacion"].Value.ToString();
                txtCampo2.Text = row.Cells["JefeOrganizacion"].Value.ToString();
                txtCampo3.Text = row.Cells["AreaTotal"].Value.ToString();
                cmbReferencia.SelectedItem = FindComboBoxItemByValue((int)row.Cells["ID_complejo"].Value);
            }
            else
            {
                txtCampo1.Text = row.Cells["Deporte"].Value.ToString();
                txtCampo2.Text = row.Cells["IndicadorLocalizacion"].Value.ToString();
                cmbReferencia.SelectedItem = FindComboBoxItemByValue((int)row.Cells["ID_area"].Value);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvComplejos.SelectedRows.Count == 0 || cmbReferencia.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un complejo para guardar.");
                return;
            }

            try
            {
                string query;
                SqlCommand command;
                DataGridViewRow row = dgvComplejos.SelectedRows[0];
                var selectedReference = (ComboBoxItem)cmbReferencia.SelectedItem;
                int referenceID = (int)selectedReference.Value;

                if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
                {
                    int id = int.Parse(row.Cells["ID_complejo"].Value.ToString());
                    query = "UPDATE Complejo SET ID_sede = @idSede, Localizacion = @localizacion, Jefe_organizacion = @jefeOrganizacion, Area_total = @areaTotal WHERE ID_complejo = @id";
                    command = new SqlCommand(query, dbConnection.OpenConnection());
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idSede", referenceID);
                    command.Parameters.AddWithValue("@localizacion", txtCampo1.Text);
                    command.Parameters.AddWithValue("@jefeOrganizacion", txtCampo2.Text);
                    command.Parameters.AddWithValue("@areaTotal", decimal.Parse(txtCampo3.Text));
                }
                else
                {
                    int id = int.Parse(row.Cells["ID_area"].Value.ToString());
                    query = "UPDATE Complejo_Polideportivo_Area SET ID_complejo = @idComplejo, Deporte = @deporte, Indicador_localizacion = @indicadorLocalizacion WHERE ID_area = @id";
                    command = new SqlCommand(query, dbConnection.OpenConnection());
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idComplejo", referenceID);
                    command.Parameters.AddWithValue("@deporte", txtCampo1.Text);
                    command.Parameters.AddWithValue("@indicadorLocalizacion", txtCampo2.Text);
                }

                command.ExecuteNonQuery();
                dbConnection.CloseConnection();
                MessageBox.Show("Complejo actualizado exitosamente.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el complejo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComplejos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un complejo para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este complejo?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dgvComplejos.SelectedRows[0];
                    string query;
                    SqlCommand command;

                    if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
                    {
                        int id = int.Parse(row.Cells["ID_complejo"].Value.ToString());
                        query = "DELETE FROM Complejo WHERE ID_complejo = @id";
                        command = new SqlCommand(query, dbConnection.OpenConnection());
                        command.Parameters.AddWithValue("@id", id);
                    }
                    else
                    {
                        int id = int.Parse(row.Cells["ID_area"].Value.ToString());
                        query = "DELETE FROM Complejo_Polideportivo_Area WHERE ID_area = @id";
                        command = new SqlCommand(query, dbConnection.OpenConnection());
                        command.Parameters.AddWithValue("@id", id);
                    }

                    command.ExecuteNonQuery();
                    dbConnection.CloseConnection();
                    MessageBox.Show("Complejo eliminado exitosamente.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el complejo: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtCampo1.Text = "";
            txtCampo2.Text = "";
            txtCampo3.Text = "";
            cmbReferencia.SelectedItem = null;
        }

        private bool ValidateFields()
        {
            if (cmbTipoComplejo.SelectedItem.ToString() == "Deporte Único")
            {
                return !string.IsNullOrWhiteSpace(txtCampo1.Text) &&
                       !string.IsNullOrWhiteSpace(txtCampo2.Text) &&
                       !string.IsNullOrWhiteSpace(txtCampo3.Text);
            }
            else
            {
                return !string.IsNullOrWhiteSpace(txtCampo1.Text) &&
                       !string.IsNullOrWhiteSpace(txtCampo2.Text);
            }
        }

        private ComboBoxItem FindComboBoxItemByValue(int value)
        {
            foreach (ComboBoxItem item in cmbReferencia.Items)
            {
                if ((int)item.Value == value)
                    return item;
            }
            return null;
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}



