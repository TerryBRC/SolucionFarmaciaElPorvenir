using DevExpress.Utils.DirectXPaint;
using FarmaciaElPorvenir.el_porvenirdb;
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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void HabilitarBotones(bool b)
        {
            btnNuevo.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = b;
            btnCancelar.Enabled = b;
            txtDir.Enabled = b;
            txtNombre.Enabled = b;
            txtTel.Enabled = b;
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtTel.Clear();
            txtDir.Clear();
            txtNombre.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            HabilitarBotones(true);
            Limpiar();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false);
        }

        private void gridViewClientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle>=0)
            {
                HabilitarBotones(true);
                string nombre = gridViewClientes.GetRowCellValue(e.RowHandle, "Nombre_Completo").ToString();
                string dir = gridViewClientes.GetRowCellValue(e.RowHandle, "Direccion").ToString();
                string tel = gridViewClientes.GetRowCellValue(e.RowHandle, "Telefono").ToString();
                txtNombre.Text = nombre;
                txtDir.Text = dir;
                txtTel.Text = tel;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente c = (Cliente)gridViewClientes.GetFocusedRow();
            if (c != null)
            {
                DialogResult r = MessageBox.Show("¿Desea Eliminar Registro?", "Información del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    unitOfWorkCliente.Delete(c);
                    unitOfWorkCliente.CommitChanges();
                    xpCollectionCliente.Reload();
                    Limpiar();
                    HabilitarBotones(false);
                }
            }
            else
            {
                MessageBox.Show("Seleccionar un Registro", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si los campos obligatorios están vacíos
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(txtDir.Text))
            {
                MessageBox.Show("Campos Requeridos", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear o buscar el cliente en la base de datos
            Cliente c;
            int id = (int)gridViewClientes.GetFocusedRowCellValue("Id");

            if (id > 0)
            {
                // Si el ID es válido y mayor a 0, buscar el cliente existente
                c = unitOfWorkCliente.GetObjectByKey<Cliente>(id);
                if (c == null)
                {
                    MessageBox.Show("Cliente no encontrado", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // Si el ID no es válido o es 0, crear un nuevo cliente
                c = new Cliente(unitOfWorkCliente);
            }

            // Asignar los valores a las propiedades del cliente
            c.Nombre_Completo = txtNombre.Text;
            c.Telefono = int.Parse(txtTel.Text);
            c.Direccion = txtDir.Text;

            // Guardar los cambios
            c.Save();
            unitOfWorkCliente.CommitChanges();

            // Limpiar los controles del formulario
            Limpiar();

            // Mostrar un mensaje de éxito
            string mensaje = (id > 0) ? "Actualización Exitosa" : "Guardado Exitoso";
            MessageBox.Show(mensaje, "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar la colección de clientes para reflejar los cambios
            xpCollectionCliente.Reload();
            HabilitarBotones(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false);
            Limpiar();
        }
    }
}
