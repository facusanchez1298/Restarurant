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
    public partial class AgregarMedidas : Form
    {
        Conexion conexion;
        int plantilla;

        public AgregarMedidas(int plantilla)
        {
            //tenes que pasarle la plantilla facu, focus
            conexion = new Conexion();
            this.plantilla = plantilla;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String alto = textBoxAlto.Text;
            String ancho = textBoxAncho.Text;
            if (esInt(alto))
            {
                if (esInt(ancho))
                {
                    if (estanEnRango(ancho))
                    {
                        if (estanEnRango(alto))
                        {
                            conexion.guardarMedidas(ancho, alto, plantilla);
                            this.Close();
                        }
                        else Mensaje.mensajeError("el alto debe ser entero menor a 100 y mayor a 8");
                    }
                    else Mensaje.mensajeError("el ancho debe ser entero menor a 100 y mayor a 8");
                }
                else Mensaje.mensajeError("el ancho debe ser entero menor a 100 y mayor a 8");
            }
            else Mensaje.mensajeError("el alto debe ser entero menor a 100 y mayor a 8");
        }

        private bool estanEnRango(string ancho)
        {
            int num = int.Parse(ancho);

            return (num >= 8) && (num <= 40);
        }

        public bool esInt(string numero)
        {
            int x;

            if (int.TryParse(numero, out x))
            {
                return true;
            }
            else return false;
        }

        private void AgregarMedidas_Load(object sender, EventArgs e)
        {

        }
    }
}
