using DevExpress.XtraBars;
using FarmaciaElPorvenir.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaElPorvenir
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Verifica si el formulario ya está abierto
                frmClientes formularioExistente = null;
                foreach (Form form in this.MdiChildren)
                {
                    if (form is frmClientes)
                    {
                        formularioExistente = (frmClientes)form;
                        break;
                    }
                }

                // Si el formulario no está abierto, crea una nueva instancia y muéstrala
                if (formularioExistente == null)
                {
                    frmClientes nuevoFormulario = new frmClientes();
                    nuevoFormulario.MdiParent = this;
                    nuevoFormulario.Show();
                }
                else
                {
                    // Si el formulario ya está abierto, lo traemos al frente
                    formularioExistente.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Verifica si el formulario ya está abierto
                ListaClientes formularioExistente = null;
                foreach (Form form in this.MdiChildren)
                {
                    if (form is ListaClientes)
                    {
                        formularioExistente = (ListaClientes)form;
                        break;
                    }
                }

                // Si el formulario no está abierto, crea una nueva instancia y muéstrala
                if (formularioExistente == null)
                {
                    ListaClientes nuevoFormulario = new ListaClientes();
                    nuevoFormulario.MdiParent = this;
                    nuevoFormulario.Show();
                }
                else
                {
                    // Si el formulario ya está abierto, lo traemos al frente
                    formularioExistente.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }
    }
}