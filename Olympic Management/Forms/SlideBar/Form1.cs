using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Types;

namespace Olympic_Management
{
    public partial class Form1 : Form
    {
        formBienvenida bienvenida;
        formSedes sedes;
        formComplejos complejos;
        formEventos eventos;
        formComisarios comisarios;
        formEquipamiento equipamiento;
        formConsultas Consultas;
        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        bool menuExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 282)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height <= 46) 
                {
                    menuTransition.Stop();
                    menuExpand = false;
                
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void siderbarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 81)
                {
                    sidebarExpand = false;
                    siderbarTransition.Stop();

                }

            }
            else 
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 238) 
                {
                    sidebarExpand = true;
                    siderbarTransition.Stop();

                    pnBienvenida.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                    pnConsultas.Width = sidebar.Width;
                    pnSalir.Width = sidebar.Width;
                }
            
            }

        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            siderbarTransition.Start();
        }

        private void btnOpcion1_Bienvenida_Click(object sender, EventArgs e)
        {
            if (bienvenida == null)
            {
                bienvenida = new formBienvenida();
                bienvenida.FormClosed += Sedes_FormClosed;
                bienvenida.MdiParent = this;
                bienvenida.Dock = DockStyle.Fill;
                bienvenida.Show();
            }
            else
            {
                bienvenida.Activate();
            }
        }

        private void Bienvenida_FormClosed(object sender, FormClosedEventArgs e) 
        {
            bienvenida = null;
        
        }

        private void btnMenuSubOpcion1_Sede_Click(object sender, EventArgs e)
        {
            if (sedes == null)
            {
                sedes = new formSedes();
                sedes.FormClosed += Sedes_FormClosed;
                sedes.MdiParent = this;
                sedes.Dock = DockStyle.Fill;
                sedes.Show();
            }
            else
            {
                sedes.Activate();
            }
        }

        private void Sedes_FormClosed(object sender, FormClosedEventArgs e)
        {
            sedes = null;

        }

        private void btnMenuSubOpcion2_Complejos_Click(object sender, EventArgs e)
        {
            if (complejos == null)
            {
                complejos = new formComplejos();
                complejos.FormClosed += Complejos_FormClosed;
                complejos.MdiParent = this;
                complejos.Dock = DockStyle.Fill;
                complejos.Show();
            }
            else
            {
                complejos.Activate();
            }
        }

        private void Complejos_FormClosed(object sender, FormClosedEventArgs e)
        {
            complejos = null;

        }

        private void btnMenuSubOpcion3_Eventos_Click(object sender, EventArgs e)
        {
            if (eventos == null)
            {
                eventos = new formEventos();
                eventos.FormClosed += Eventos_FormClosed;
                eventos.MdiParent = this;
                eventos.Dock = DockStyle.Fill;
                eventos.Show();
            }
            else
            {
                eventos.Activate();
            }
        }

        private void Eventos_FormClosed(object sender, FormClosedEventArgs e)
        {
            eventos = null;

        }

        private void btnMenuSubOpcion4_Comisarios_Click(object sender, EventArgs e)
        {
            if (comisarios == null)
            {
                comisarios = new formComisarios();
                comisarios.FormClosed += Comisarios_FormClosed;
                comisarios.MdiParent = this;
                comisarios.Dock = DockStyle.Fill;
                comisarios.Show();
            }
            else
            {
                comisarios.Activate();
            }
        }
        private void Comisarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            comisarios = null;

        }

        private void btnMenuSubOpcion5_Equipamiento_Click(object sender, EventArgs e)
        {
            if (equipamiento == null)
            {
                equipamiento = new formEquipamiento();
                equipamiento.FormClosed += Equipamiento_FormClosed;
                equipamiento.MdiParent = this;
                equipamiento.Dock = DockStyle.Fill;
                equipamiento.Show();
            }
            else
            {
                equipamiento.Activate();
            }
        }

        private void Equipamiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            equipamiento = null;

        }

        private void btnOpcion3_Consultas_Click(object sender, EventArgs e)
        {
            if (Consultas == null)
            {
                Consultas = new formConsultas();
                Consultas.FormClosed += Consultas_FormClosed;
                Consultas.MdiParent = this;
                Consultas.Dock = DockStyle.Fill;
                Consultas.Show();
            }
            else
            {
                Consultas.Activate();
            }
        }
        private void Consultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Consultas = null;

        }

    }


}
