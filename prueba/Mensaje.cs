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
    public partial class Mensaje : Form
    {
        private Mensaje(string mensaje)
        {
            InitializeComponent();
            label1.Text = mensaje;
        }

        private Mensaje(string mensaje, string titulo)
        {
            InitializeComponent();
            label1.Text = mensaje;
            this.Text = titulo;
        }

        public static void mensajeError(string mensaje)
        {
            Mensaje msm = new Mensaje(mensaje);
            msm.ShowDialog();
        }

        internal static bool mensajePregunta(string mensaje, string titulo)
        {
           var result = MessageBox.Show(mensaje,
                                    titulo, 
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        public static void mensajeError(string mensaje, String titulo)
        {
            Mensaje msm = new Mensaje(mensaje, titulo);
            msm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
