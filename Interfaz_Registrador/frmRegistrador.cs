using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Hotel;

namespace Interfaz_Registrador
{
    public partial class frmRegistrador : Form
    {
        string alternativa;
        public frmRegistrador()
        {
            InitializeComponent();
        }


        private void frmRegistrador_Load(object sender, EventArgs e)
        {
            ActualizarListaRegistradores();
            BloquearFormulario();
        }


        private void BloquearFormulario()
        {
            txtCodRegistrador.Enabled = false;
            txtNombreRegistrador.Enabled = false;
            txtDireccionRegistrador.Enabled = false;
            txtTelefonoRegistrador.Enabled = false;
            txtNroDocumentoRegistrador.Enabled = false;
            txtObservacionRegistrador.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstRegistrador.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }


        private void ActualizarListaRegistradores()
        {
            lstRegistrador.DataSource = null;
            lstRegistrador.DataSource = Registrador.ObtenerRegistradores();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var r = ObtenerDatosFormulario();                                                                                                       

            if (alternativa == "Agregar")
            {
                Registrador.AgregarRegistrador(r);
            }

            else if (alternativa == "Actualizar")    
            {

                if (this.lstRegistrador.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una fila para Actualizar.");
                }

                else
                {
                    int indice = lstRegistrador.SelectedIndex;
                    Registrador.ActualizarRegistrador(r, indice);
                    ActualizarListaRegistradores();
                }

            }

            LimpiarFormulario();
            ActualizarListaRegistradores();
            BloquearFormulario();

        }


        private Registrador ObtenerDatosFormulario()
        {
            Registrador registrador = new Registrador();
            registrador.ID_Registrador = txtCodRegistrador.Text;
            registrador.Nombre = txtNombreRegistrador.Text;
            registrador.Direccion = txtDireccionRegistrador.Text;
            registrador.Telefono = txtTelefonoRegistrador.Text;
            registrador.NroDocumento = txtNroDocumentoRegistrador.Text;       
            registrador.Observacion = txtObservacionRegistrador.Text;

            return registrador;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtCodRegistrador.Focus();
        }

        private void LimpiarFormulario()
        {
            txtCodRegistrador.Text = "";
            txtNombreRegistrador.Text = "";
            txtDireccionRegistrador.Text = "";
            txtTelefonoRegistrador.Text = "";
            txtNroDocumentoRegistrador.Text = "";
            txtObservacionRegistrador.Text = "";
        }


        private void DesbloquearFormulario()
        {
            txtCodRegistrador.Enabled = true;
            txtNombreRegistrador.Enabled = true;
            txtDireccionRegistrador.Enabled = true;
            txtTelefonoRegistrador.Enabled = true;
            txtNroDocumentoRegistrador.Enabled = true;
            txtObservacionRegistrador.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstRegistrador.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            
        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstRegistrador.SelectedItems.Count == 0)
            {
                MessageBox.Show("Favor seleccione una fila para Actualizar.");
            }

            else
            {
                alternativa = "Actualizar";
                DesbloquearFormulario();
                txtCodRegistrador.Focus();
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstRegistrador.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar");
            }

            else
            {
                Registrador r = (Registrador)lstRegistrador.SelectedItem;
                Registrador.EliminarRegistrador(r);
                ActualizarListaRegistradores();
                LimpiarFormulario();
            }
        }

        private void lstRegistrador_SelectedIndexChanged(object sender, EventArgs e)
        {
            Registrador r = (Registrador)lstRegistrador.SelectedItem;

            if (r != null)
            {
                txtCodRegistrador.Text = r.ID_Registrador;
                txtNombreRegistrador.Text = r.Nombre;
                txtDireccionRegistrador.Text = r.Direccion;
                txtTelefonoRegistrador.Text = r.Telefono;
                txtNroDocumentoRegistrador.Text = r.NroDocumento;
                txtObservacionRegistrador.Text = r.Observacion;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}
