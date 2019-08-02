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
    public partial class Pedido : Form, Dar
    {
        Datos padre;
        Item item;
        Conexion conexion;

        public Pedido()
        {

            conexion = new Conexion();
            InitializeComponent();
            RecargarTabla();
            
        }

        public void salir()
        {
            this.Close();
        }

        public void RecargarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = conexion.CargarTablaComida();
            dataGridView1.Columns[0].Visible = false;
        }


        public void darItem(Item item)
        {
            this.item = item;
        }

        public void darPadre(Form form)
        {
            padre = form as Datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            while (this.Size.Width <= 0)
            {
                this.Width -= 1;
            }
            this.Close();
        }

        

        private void textBoxFiltrar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.CargarTablaComida(textBoxFiltrar.Text, checkBoxVegetariano.Checked, checkBoxSinTACC.Checked);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                int id_comida = int.Parse(fila.Cells[0].Value.ToString());
                conexion.agregarPedido(padre, id_comida, 1, padre.padre.plantilla);
                this.padre.refrescarTabla();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.CargarTablaComida(textBoxFiltrar.Text, checkBoxVegetariano.Checked, checkBoxSinTACC.Checked);
        }

        private void checkBoxSinTACC_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.CargarTablaComida(textBoxFiltrar.Text, checkBoxVegetariano.Checked, checkBoxSinTACC.Checked);
        }
    }
}
