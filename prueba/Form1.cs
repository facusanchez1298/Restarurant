
using System.Drawing;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {       
        Ver padre;
        

        public Form1( Ver padre, int numero)
        {
            this.padre = padre;
            InitializeComponent();
            editor.plantilla = numero;
            editor.Focus();
        }

        public void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
            padre.Show();
            padre.recargarPlano();
        }

        



    }
}
