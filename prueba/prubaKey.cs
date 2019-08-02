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
    public partial class prubaKey : Form
    {
        public prubaKey()
        {
            InitializeComponent();
        }

        private void prubaKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mensaje.mensajeError("aaaaa");
        }
    }
}
