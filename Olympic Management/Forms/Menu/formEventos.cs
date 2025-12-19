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
    public partial class formEventos : Form
    {
        private DatabaseConnection dbConnection;

        public formEventos()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void formEventos_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            SetupDataGridView();
            LoadComplejos();
            LoadData();
        }

        private void SetupDataGridView()
        {
            dgvEventos.Columns.Clear();
            dgvEventos.Columns.Add("ID_evento", "ID");
            dgvEventos.Columns.Add("ID_complejo", "ID Complejo");
            dgvEventos.Columns.Add("Nombre", "Nombre del Evento");
            dgvEventos.Columns.Add("Fecha", "Fecha");
            dgvEventos.Columns.Add("Duracion", "Duración (min)");
            dgvEventos.Columns.Add("Numero_participantes", "Número de Participantes");
            dgvEventos.Columns.Add("Numero_comisarios", "Número de Comisarios");
            dgvEventos.Columns["ID_evento"].Visible = false;
            dgvEventos.Columns["ID_complejo"].Visible = false;
        }

        private void LoadComplejos()
        {
            try
            {
                cmbComplejos.Items.Clear();
                string query = "SELECT ID_complejo, Localizacion FROM Complejo";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                while (reader.Read())
                {
                    cmbComplejos.Items.Add(new ComboBoxItem2
                    {
                        Text = reader["Localizacion"].ToString(),
                        Value = Convert.ToInt32(reader["ID_complejo"]) // Convertir a int antes de asignar
                    });
                }

                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar complejos: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM Evento";
                SqlDataReader reader = dbConnection.ExecuteQuery(query);

                dgvEventos.Rows.Clear();
                while (reader.Read())
                {
                    dgvEventos.Rows.Add(
                        reader["ID_evento"].ToString(),
                        reader["ID_complejo"].ToString(),
                        reader["Nombre"].ToString(),
                        DateTime.Parse(reader["Fecha"].ToString()).ToString("yyyy-MM-dd HH:mm:ss"), // Formato de fecha
                        reader["Duracion"].ToString(),
                        reader["Numero_participantes"].ToString(),
                        reader["Numero_comisarios"].ToString()
                    );
                }

                reader.Close();
                dbConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void txtNumeroParticipantes_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroParticipantes.Text, out int numParticipantes))
            {
                lblNumeroComisarios.Text = (numParticipantes / 10).ToString(); // Asigna un comisario cada 10 participantes
            }
            else
            {
                lblNumeroComisarios.Text = "0"; // Valor por defecto si el campo está vacío o no es un número
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                string nombre = txtNombreEvento.Text;
                DateTime fecha = dtpFecha.Value;
                int duracion = int.Parse(txtDuracion.Text);
                int numParticipantes = int.Parse(txtNumeroParticipantes.Text);

                // Verificar el cálculo de comisarios
                int numComisarios = int.Parse(lblNumeroComisarios.Text);
                if (numComisarios == 0)
                {
                    MessageBox.Show("Advertencia: El número de comisarios es 0, verifica el cálculo.");
                }

                // Verificar el valor del complejo seleccionado
                if (cmbComplejos.SelectedItem == null)
                {
                    MessageBox.Show("Error: No se ha seleccionado un complejo.");
                    return;
                }
                int idComplejo = ((ComboBoxItem2)cmbComplejos.SelectedItem).Value;

                // Mostrar valores para verificar antes de ejecutar el comando SQL
                MessageBox.Show($"Nombre: {nombre}\nFecha: {fecha}\nDuración: {duracion}\n" +
                                $"Participantes: {numParticipantes}\nComisarios: {numComisarios}\nComplejo: {idComplejo}");

                string query = "INSERT INTO Evento (ID_complejo, Nombre, Fecha, Duracion, Numero_participantes, Numero_comisarios) " +
                               "VALUES (@idComplejo, @nombre, @fecha, @duracion, @numParticipantes, @numComisarios)";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@idComplejo", idComplejo);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@duracion", duracion);
                command.Parameters.AddWithValue("@numParticipantes", numParticipantes);
                command.Parameters.AddWithValue("@numComisarios", numComisarios);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Evento agregado exitosamente.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el evento: " + ex.Message);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un evento para editar.");
                return;
            }

            DataGridViewRow row = dgvEventos.SelectedRows[0];
            txtNombreEvento.Text = row.Cells["Nombre"].Value.ToString();
            dtpFecha.Value = DateTime.Parse(row.Cells["Fecha"].Value.ToString());
            txtDuracion.Text = row.Cells["Duracion"].Value.ToString();
            txtNumeroParticipantes.Text = row.Cells["Numero_participantes"].Value.ToString();
            lblNumeroComisarios.Text = row.Cells["Numero_comisarios"].Value.ToString();

            foreach (ComboBoxItem2 item in cmbComplejos.Items)
            {
                if (item.Value == int.Parse(row.Cells["ID_complejo"].Value.ToString()))
                {
                    cmbComplejos.SelectedItem = item;
                    break;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un evento para guardar.");
                return;
            }

            try
            {
                int idEvento = int.Parse(dgvEventos.SelectedRows[0].Cells["ID_evento"].Value.ToString());
                string nombre = txtNombreEvento.Text;
                DateTime fecha = dtpFecha.Value; // Usa directamente el valor DateTime
                int duracion = int.Parse(txtDuracion.Text);
                int numParticipantes = int.Parse(txtNumeroParticipantes.Text);
                int numComisarios = int.Parse(lblNumeroComisarios.Text);
                int idComplejo = ((ComboBoxItem2)cmbComplejos.SelectedItem).Value;

                string query = "UPDATE Evento SET ID_complejo = @idComplejo, Nombre = @nombre, Fecha = @fecha, " +
                               "Duracion = @duracion, Numero_participantes = @numParticipantes, Numero_comisarios = @numComisarios " +
                               "WHERE ID_evento = @idEvento";
                SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                command.Parameters.AddWithValue("@idEvento", idEvento);
                command.Parameters.AddWithValue("@idComplejo", idComplejo);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@fecha", fecha);  // Usa directamente el valor DateTime
                command.Parameters.AddWithValue("@duracion", duracion);
                command.Parameters.AddWithValue("@numParticipantes", numParticipantes);
                command.Parameters.AddWithValue("@numComisarios", numComisarios);
                command.ExecuteNonQuery();

                dbConnection.CloseConnection();
                MessageBox.Show("Evento actualizado exitosamente.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el evento: " + ex.Message);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un evento para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este evento?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    int idEvento = int.Parse(dgvEventos.SelectedRows[0].Cells["ID_evento"].Value.ToString());
                    string query = "DELETE FROM Evento WHERE ID_evento = @idEvento";
                    SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
                    command.Parameters.AddWithValue("@idEvento", idEvento);
                    command.ExecuteNonQuery();

                    dbConnection.CloseConnection();
                    MessageBox.Show("Evento eliminado exitosamente.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el evento: " + ex.Message);
                }
            }
        }

        private void ClearFields()
        {
            txtNombreEvento.Text = "";
            dtpFecha.Value = DateTime.Today;
            txtDuracion.Text = "";
            txtNumeroParticipantes.Text = "";
            lblNumeroComisarios.Text = "0";
            cmbComplejos.SelectedIndex = -1;
        }

        private bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(txtNombreEvento.Text) &&
                   cmbComplejos.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(txtDuracion.Text) &&
                   !string.IsNullOrWhiteSpace(txtNumeroParticipantes.Text);
        }
    }

    // Clase auxiliar para ComboBoxItem
    public class ComboBoxItem2
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}


