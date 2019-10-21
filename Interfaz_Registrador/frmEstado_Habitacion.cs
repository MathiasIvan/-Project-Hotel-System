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
    public partial class frmEstado_Habitacion : Form
    {
        string alternativa;
        public frmEstado_Habitacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var et = ObtenerDatosFormulario();


            if (alternativa == "Agregar")
            {
                Estado_Habitacion.AgregarEstadoHabitacion(et);
            }
            else if (alternativa == "Actualizar")
            {

                if (this.lstEstadoHabitacion.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione una Fila para Acualizar. ");
                }

                else
                {
                    int indice = lstEstadoHabitacion.SelectedIndex;
                    Estado_Habitacion.AcualizarEstadoHabitacion(et, indice);
                    ActualizarListaEstadoHabitacion();
                }


            }

            LimpiarFormulario();
            ActualizarListaEstadoHabitacion();
            BloquearFormulario();

        }
        private Estado_Habitacion ObtenerDatosFormulario()
        {
            Estado_Habitacion estadoHabitacion = new Estado_Habitacion();
            estadoHabitacion.ID_EstadoHabitacion = Convert.ToInt32(txtCodigoHabitacion.Text);
            estadoHabitacion.Descripcion = txtDescripcion.Text;        

            return estadoHabitacion;

        }
        private void LimpiarFormulario()
        {
            txtCodigoHabitacion.Text = "";
            txtDescripcion.Text = "";

        }
        private void ActualizarListaEstadoHabitacion()
        {
            lstEstadoHabitacion.DataSource = null;
            lstEstadoHabitacion.DataSource = Estado_Habitacion.ObtenerEstadoHabitacion();
        }
        private void BloquearFormulario()
        {
            txtCodigoHabitacion.Enabled = false;
            txtDescripcion.Enabled = false;

            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            lstEstadoHabitacion.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            alternativa = "Agregar";
            LimpiarFormulario();
            DesbloquearFormularios();
            txtCodigoHabitacion.Focus();
        }
        private void DesbloquearFormularios()
        {
            txtCodigoHabitacion.Enabled = true;
            txtDescripcion.Enabled = true;

            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstEstadoHabitacion.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.lstEstadoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una Fila para Acualizar. ");
            }
            else
            {
                alternativa = "Actualizar";
                DesbloquearFormularios();
                txtCodigoHabitacion.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstEstadoHabitacion.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una Fila para Eliminar. ");
            }
            else
            {
                Estado_Habitacion et = (Estado_Habitacion)lstEstadoHabitacion.SelectedItem;
                Estado_Habitacion.EliminarEstadoHabitacion(et);
                ActualizarListaEstadoHabitacion();
                LimpiarFormulario();
            }
        }

        private void frmEstado_Habitacion_Load(object sender, EventArgs e)
        {
            ActualizarListaEstadoHabitacion();
            BloquearFormulario();
        }

        private void lstEstadoHabitacion_Click(object sender, EventArgs e)
        {
            Estado_Habitacion et = (Estado_Habitacion)lstEstadoHabitacion.SelectedItem;

            if (et != null)
            {
                txtCodigoHabitacion.Text = et.ID_EstadoHabitacion.ToString();
                txtDescripcion.Text = et.Descripcion;
            }
        }
    }
}
