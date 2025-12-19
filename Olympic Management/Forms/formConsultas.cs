using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Olympic_Management.Database;

namespace Olympic_Management
{
    public partial class formConsultas : Form
    {
        private DatabaseConnection dbConnection;

        public formConsultas()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        private void formConsultas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {
            cmbSeleccionConsulta.Items.Add("Complejos Afiliados a Sedes");
            cmbSeleccionConsulta.Items.Add("Eventos por Comisario");
            cmbSeleccionConsulta.Items.Add("Equipamiento Total por Complejo");
            cmbSeleccionConsulta.Items.Add("Eventos en Fecha Específica");
            cmbSeleccionConsulta.Items.Add("Participación Total en Eventos por Complejo");
            cmbSeleccionConsulta.Items.Add("Comisarios Asignados por Evento");
            cmbSeleccionConsulta.Items.Add("Presupuesto Total por Sede");
            cmbSeleccionConsulta.Items.Add("Próximos Eventos con Equipamiento Específico");
            cmbSeleccionConsulta.Items.Add("Complejos con Mayor Participación en Eventos");
            cmbSeleccionConsulta.Items.Add("Detalle de Eventos y Comisarios por Complejo");
            cmbSeleccionConsulta.SelectedIndexChanged += cmbSeleccionConsulta_SelectedIndexChanged;

            lblFiltroDinamico.Visible = false;
            cmbFiltroDinamico.Visible = false;
            lblFechaInicio.Visible = false;
            dtpFechaInicioFiltro.Visible = false;
            lblFechaFinal.Visible = false;
            dtpFechaFinFiltro.Visible = false;
            lblFiltroUmbral.Visible = false;
            txtUmbralFiltro.Visible = false;
            dgvResultados.Columns.Clear();
        }

        private void cmbSeleccionConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarFiltros();
            cmbFiltroDinamico.Items.Clear();

            switch (cmbSeleccionConsulta.SelectedItem.ToString())
            {
                case "Complejos Afiliados a Sedes":
                    lblFiltroDinamico.Text = "Sede:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarSedes();
                    break;

                case "Eventos por Comisario":
                    lblFiltroDinamico.Text = "Comisario:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarComisarios();
                    break;

                case "Equipamiento Total por Complejo":
                    lblFiltroDinamico.Text = "Complejo:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarComplejos();
                    break;

                case "Eventos en Fecha Específica":
                    lblFechaInicio.Text = "Fecha Inicio:";
                    lblFechaFinal.Text = "Fecha Fin:";
                    lblFechaInicio.Visible = true;
                    dtpFechaInicioFiltro.Visible = true;
                    lblFechaFinal.Visible = true;
                    dtpFechaFinFiltro.Visible = true;
                    break;

                case "Participación Total en Eventos por Complejo":
                    lblFiltroDinamico.Text = "Complejo:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarComplejos();
                    break;

                case "Comisarios Asignados por Evento":
                    lblFiltroDinamico.Text = "Evento:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarEventos();
                    break;

                case "Presupuesto Total por Sede":
                    lblFiltroDinamico.Text = "Sede:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarSedes();
                    break;

                case "Próximos Eventos con Equipamiento Específico":
                    lblFiltroDinamico.Text = "Equipamiento:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    lblFechaInicio.Visible = true;
                    dtpFechaInicioFiltro.Visible = true;
                    CargarEquipamiento();
                    break;

                case "Complejos con Mayor Participación en Eventos":
                    lblFiltroUmbral.Text = "Mínimo Participantes:";
                    lblFiltroUmbral.Visible = true;
                    txtUmbralFiltro.Visible = true;
                    break;

                case "Detalle de Eventos y Comisarios por Complejo":
                    lblFiltroDinamico.Text = "Complejo:";
                    lblFiltroDinamico.Visible = true;
                    cmbFiltroDinamico.Visible = true;
                    CargarComplejos();
                    break;
            }
        }

        private void OcultarFiltros()
        {
            lblFiltroDinamico.Visible = false;
            cmbFiltroDinamico.Visible = false;
            lblFechaInicio.Visible = false;
            dtpFechaInicioFiltro.Visible = false;
            lblFechaFinal.Visible = false;
            dtpFechaFinFiltro.Visible = false;
            lblFiltroUmbral.Visible = false;
            txtUmbralFiltro.Visible = false;
        }

        private void CargarSedes()
        {
            cmbFiltroDinamico.Items.Clear();
            string query = "SELECT ID_sede, Nombre FROM Sede";
            SqlDataReader reader = dbConnection.ExecuteQuery(query);
            while (reader.Read())
            {
                cmbFiltroDinamico.Items.Add(new ComboBoxItem3
                {
                    Text = reader["Nombre"].ToString(),
                    Value = Convert.ToInt32(reader["ID_sede"])
                });
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void CargarComisarios()
        {
            cmbFiltroDinamico.Items.Clear();
            string query = "SELECT ID_comisario, Nombre FROM Comisario";
            SqlDataReader reader = dbConnection.ExecuteQuery(query);
            while (reader.Read())
            {
                cmbFiltroDinamico.Items.Add(new ComboBoxItem3
                {
                    Text = reader["Nombre"].ToString(),
                    Value = Convert.ToInt32(reader["ID_comisario"])
                });
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void CargarComplejos()
        {
            cmbFiltroDinamico.Items.Clear();
            string query = "SELECT ID_complejo, Localizacion FROM Complejo";
            SqlDataReader reader = dbConnection.ExecuteQuery(query);
            while (reader.Read())
            {
                cmbFiltroDinamico.Items.Add(new ComboBoxItem3
                {
                    Text = reader["Localizacion"].ToString(),
                    Value = Convert.ToInt32(reader["ID_complejo"])
                });
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void CargarEventos()
        {
            cmbFiltroDinamico.Items.Clear();
            string query = "SELECT ID_evento, Nombre FROM Evento";
            SqlDataReader reader = dbConnection.ExecuteQuery(query);
            while (reader.Read())
            {
                cmbFiltroDinamico.Items.Add(new ComboBoxItem3
                {
                    Text = reader["Nombre"].ToString(),
                    Value = Convert.ToInt32(reader["ID_evento"])
                });
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void CargarEquipamiento()
        {
            cmbFiltroDinamico.Items.Clear();
            string query = "SELECT ID_equipamiento, Nombre FROM Equipamiento";
            SqlDataReader reader = dbConnection.ExecuteQuery(query);
            while (reader.Read())
            {
                cmbFiltroDinamico.Items.Add(new ComboBoxItem3
                {
                    Text = reader["Nombre"].ToString(),
                    Value = Convert.ToInt32(reader["ID_equipamiento"])
                });
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consultaSeleccionada = cmbSeleccionConsulta.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(consultaSeleccionada))
            {
                MessageBox.Show("Seleccione una consulta válida.");
                return;
            }

            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            // Validar la entrada según la consulta seleccionada
            switch (consultaSeleccionada)
            {
                case "Complejos Afiliados a Sedes":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione una sede.");
                        return;
                    }
                    EjecutarConsultaComplejosAfiliados();
                    break;

                case "Eventos por Comisario":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un comisario.");
                        return;
                    }
                    EjecutarConsultaEventosPorComisario();
                    break;

                case "Equipamiento Total por Complejo":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un complejo.");
                        return;
                    }
                    EjecutarConsultaEquipamientoTotalPorComplejo();
                    break;

                case "Eventos en Fecha Específica":
                    if (dtpFechaInicioFiltro.Value > dtpFechaFinFiltro.Value)
                    {
                        MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.");
                        return;
                    }
                    EjecutarConsultaEventosEnFechaEspecifica();
                    break;

                case "Participación Total en Eventos por Complejo":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un complejo.");
                        return;
                    }
                    EjecutarConsultaParticipacionTotalPorComplejo();
                    break;

                case "Comisarios Asignados por Evento":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un evento.");
                        return;
                    }
                    EjecutarConsultaComisariosPorEvento();
                    break;

                case "Presupuesto Total por Sede":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione una sede.");
                        return;
                    }
                    EjecutarConsultaPresupuestoPorSede();
                    break;

                case "Próximos Eventos con Equipamiento Específico":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un equipamiento.");
                        return;
                    }
                    EjecutarConsultaProximosEventosConEquipamiento();
                    break;

                case "Complejos con Mayor Participación en Eventos":
                    if (string.IsNullOrWhiteSpace(txtUmbralFiltro.Text) || !int.TryParse(txtUmbralFiltro.Text, out _))
                    {
                        MessageBox.Show("Ingrese un valor válido para el mínimo de participantes.");
                        return;
                    }
                    EjecutarConsultaComplejosMayorParticipacion();
                    break;

                case "Detalle de Eventos y Comisarios por Complejo":
                    if (cmbFiltroDinamico.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un complejo.");
                        return;
                    }
                    EjecutarConsultaDetalleEventosYComisarios();
                    break;

                default:
                    MessageBox.Show("Seleccione una consulta válida.");
                    break;
            }
        }



        private void EjecutarConsultaComplejosAfiliados()
        {
            int sedeId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = $"SELECT Localizacion FROM Complejo WHERE ID_sede = @sedeId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@sedeId", sedeId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Localizacion", "Localización del Complejo");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Localizacion"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaEventosPorComisario()
        {
            int comisarioId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = "SELECT Evento.Nombre, Evento.Fecha FROM Evento " +
                           "JOIN Evento_Comisario ON Evento.ID_evento = Evento_Comisario.ID_evento " +
                           "WHERE Evento_Comisario.ID_comisario = @comisarioId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@comisarioId", comisarioId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Nombre", "Nombre del Evento");
            dgvResultados.Columns.Add("Fecha", "Fecha del Evento");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Nombre"].ToString(), reader["Fecha"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaEquipamientoTotalPorComplejo()
        {
            int complejoId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = "SELECT Equipamiento.Nombre, Mantenimiento_Equipamiento.Cantidad " +
                           "FROM Mantenimiento_Equipamiento " +
                           "JOIN Equipamiento ON Mantenimiento_Equipamiento.ID_equipamiento = Equipamiento.ID_equipamiento " +
                           "WHERE Mantenimiento_Equipamiento.ID_complejo = @complejoId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@complejoId", complejoId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Nombre", "Nombre del Equipamiento");
            dgvResultados.Columns.Add("Cantidad", "Cantidad Total");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Nombre"].ToString(), reader["Cantidad"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaEventosEnFechaEspecifica()
        {
            DateTime fechaInicio = dtpFechaInicioFiltro.Value;
            DateTime fechaFin = dtpFechaFinFiltro.Value;
            string query = "SELECT Nombre, Fecha, Duracion, Numero_participantes " +
                           "FROM Evento WHERE Fecha BETWEEN @fechaInicio AND @fechaFin";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@fechaFin", fechaFin);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Nombre", "Nombre del Evento");
            dgvResultados.Columns.Add("Fecha", "Fecha del Evento");
            dgvResultados.Columns.Add("Duracion", "Duración (min)");
            dgvResultados.Columns.Add("Numero_participantes", "Número de Participantes");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Nombre"].ToString(), reader["Fecha"].ToString(), reader["Duracion"].ToString(), reader["Numero_participantes"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaParticipacionTotalPorComplejo()
        {
            int complejoId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = "SELECT SUM(Numero_participantes) AS TotalParticipantes FROM Evento WHERE ID_complejo = @complejoId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@complejoId", complejoId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("TotalParticipantes", "Participación Total");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["TotalParticipantes"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaComisariosPorEvento()
        {
            int eventoId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = "SELECT Comisario.Nombre, Evento_Comisario.Rol " +
                           "FROM Evento_Comisario " +
                           "JOIN Comisario ON Evento_Comisario.ID_comisario = Comisario.ID_comisario " +
                           "WHERE Evento_Comisario.ID_evento = @eventoId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@eventoId", eventoId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Nombre", "Nombre del Comisario");
            dgvResultados.Columns.Add("Rol", "Rol en Evento");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Nombre"].ToString(), reader["Rol"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaPresupuestoPorSede()
        {
            int sedeId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = "SELECT Nombre, Presupuesto_aproximado FROM Sede WHERE ID_sede = @sedeId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@sedeId", sedeId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Nombre", "Nombre de la Sede");
            dgvResultados.Columns.Add("Presupuesto_aproximado", "Presupuesto Aproximado");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Nombre"].ToString(), reader["Presupuesto_aproximado"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaProximosEventosConEquipamiento()
        {
            int equipamientoId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            DateTime fechaInicio = dtpFechaInicioFiltro.Value;
            string query = "SELECT Evento.Nombre, Evento.Fecha FROM Evento_Equipamiento " +
                           "JOIN Evento ON Evento_Equipamiento.ID_evento = Evento.ID_evento " +
                           "WHERE Evento_Equipamiento.ID_equipamiento = @equipamientoId " +
                           "AND Evento.Fecha >= @fechaInicio";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@equipamientoId", equipamientoId);
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Nombre", "Nombre del Evento");
            dgvResultados.Columns.Add("Fecha", "Fecha del Evento");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Nombre"].ToString(), reader["Fecha"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaComplejosMayorParticipacion()
        {
            int umbral = int.Parse(txtUmbralFiltro.Text);
            string query = "SELECT Complejo.Localizacion, SUM(Evento.Numero_participantes) AS ParticipacionTotal " +
                           "FROM Evento " +
                           "JOIN Complejo ON Evento.ID_complejo = Complejo.ID_complejo " +
                           "GROUP BY Complejo.Localizacion " +
                           "HAVING SUM(Evento.Numero_participantes) >= @umbral";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@umbral", umbral);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("Localizacion", "Localización del Complejo");
            dgvResultados.Columns.Add("ParticipacionTotal", "Participación Total");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["Localizacion"].ToString(), reader["ParticipacionTotal"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void EjecutarConsultaDetalleEventosYComisarios()
        {
            int complejoId = ((ComboBoxItem3)cmbFiltroDinamico.SelectedItem).Value;
            string query = "SELECT Evento.Nombre AS EventoNombre, Comisario.Nombre AS ComisarioNombre, Evento_Comisario.Rol " +
                           "FROM Evento " +
                           "JOIN Evento_Comisario ON Evento.ID_evento = Evento_Comisario.ID_evento " +
                           "JOIN Comisario ON Evento_Comisario.ID_comisario = Comisario.ID_comisario " +
                           "WHERE Evento.ID_complejo = @complejoId";
            SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection());
            command.Parameters.AddWithValue("@complejoId", complejoId);
            SqlDataReader reader = command.ExecuteReader();

            dgvResultados.Columns.Add("EventoNombre", "Nombre del Evento");
            dgvResultados.Columns.Add("ComisarioNombre", "Nombre del Comisario");
            dgvResultados.Columns.Add("Rol", "Rol en Evento");
            while (reader.Read())
            {
                dgvResultados.Rows.Add(reader["EventoNombre"].ToString(), reader["ComisarioNombre"].ToString(), reader["Rol"].ToString());
            }
            reader.Close();
            dbConnection.CloseConnection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Desactivar temporalmente el evento SelectedIndexChanged del ComboBox para evitar errores
            cmbSeleccionConsulta.SelectedIndexChanged -= cmbSeleccionConsulta_SelectedIndexChanged;

            // Restablecer la selección del ComboBox y limpiar los filtros
            cmbSeleccionConsulta.SelectedIndex = -1;
            cmbFiltroDinamico.Items.Clear();
            dtpFechaInicioFiltro.Value = DateTime.Today;
            dtpFechaFinFiltro.Value = DateTime.Today;
            txtUmbralFiltro.Text = "";

            // Limpiar el DataGridView y ocultar los filtros
            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();
            OcultarFiltros();

            // Volver a activar el evento SelectedIndexChanged del ComboBox
            cmbSeleccionConsulta.SelectedIndexChanged += cmbSeleccionConsulta_SelectedIndexChanged;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //Boton para exportar los reportes de consultas
        }
    }

    // Clase auxiliar para ComboBoxItem
    public class ComboBoxItem3
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}



