using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class EditarMozo : Form
    {

        Conexion Conexion;
        Mozos padre;
        int id;

        public EditarMozo(Mozos padre, int id)
        {
            this.id = id;
            this.padre = padre;
            Conexion = new Conexion();
            InitializeComponent();
            Conexion.cargarTablaMozos(this, id);
        }



        private void salir_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Any())
            {

                if (Mensaje.mensajePregunta("seguro quieres salir sin guardar?", "seguro desea salir?"))
                {
                    this.Close();
                    this.padre.recargarTabla();
                }
            }
            else this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {

            string nombre = textBoxNombre.Text;
            bool estaALaMañana = checkBoxMañana.Checked;
            bool estaALaTarde = checkBoxTarde.Checked;
            bool estaALaNoche = checkBoxNoche.Checked;

            if (nombre.Any())
            {
                if (TieneTurno())
                {
                    Conexion.editarMozo(id, nombre, estaALaMañana, estaALaTarde, estaALaNoche);
                    vaciarCampos();
                    padre.recargarTabla();
                    Mensaje.mensajeError("se agrego con exito");
                }
                else Mensaje.mensajeError("El mozo no tiene un turno asignado");
            }
            else Mensaje.mensajeError("El mozo no tiene nombre");

        }


        private bool TieneTurno()
        {
            bool estaALaMañana = checkBoxMañana.Checked;
            bool estaALaTarde = checkBoxTarde.Checked;
            bool estaALaNoche = checkBoxNoche.Checked;

            if (!estaALaMañana && !estaALaTarde && !estaALaNoche) return false;
            else return true;
        }

        public void vaciarCampos()
        {
            textBoxNombre.Text = "";
            checkBoxMañana.Checked = false;
            checkBoxTarde.Checked = false;
            checkBoxNoche.Checked = false;
        }

        
    }
}
