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
    public partial class EditarComida : Form
    {
        Conexion Conexion;
        int id;
        EditarMenu menu;

        public EditarComida(int id, EditarMenu menu)
        {
            this.id = id;
            InitializeComponent();
            Conexion = new Conexion();
            Conexion.cargarComida(this, id);
            this.menu = menu;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if(Mensaje.mensajePregunta("Esta seguro que desea salir sin guardar?", "salir sin guardar"))
            {
                this.Close();
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            //string nombre = textBoxNombre.Text;
            //string precio = textBoxPrecio.Text;
            //bool sinTacc = checkBoxSinTACC.Checked;
            //bool vegetariano = checkBoxVegetariano.Checked;

           

            if (!hayCamposVacios())
            {
                if (esFloat(textBoxPrecio.Text))
                {
                    string nombre = textBoxNombre.Text;
                    bool vegetariano = checkBoxVegetariano.Checked;
                    bool sinTACC = checkBoxSinTACC.Checked;
                    string precio = textBoxPrecio.Text;

                    Conexion.editarComida(id, nombre, precio, sinTACC, vegetariano);
                    Mensaje.mensajeError("se agrego con exito");
                    vaciarCampos();
                    menu.RecargarTabla();
                }
                else Mensaje.mensajeError("El precio ingresado debe ser flotante");
            }
            else Mensaje.mensajeError("hay campos vacios");
        }

        public bool hayCamposVacios()
        {
            if ((textBoxNombre.Text != "") && (textBoxPrecio.Text != ""))
            {
                return false;
            }
            else return true;
        }

        public bool esFloat(string numero)
        {
            float x;

            if (float.TryParse(numero, out x))
            {
                return true;
            }
            else return false;
        }

        public void vaciarCampos()
        {
            textBoxNombre.Text = "";
            textBoxPrecio.Text = "";
            checkBoxSinTACC.Checked = false;
            checkBoxVegetariano.Checked = false;
        }


    }
}
