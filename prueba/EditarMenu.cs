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
    public partial class EditarMenu : Form
    {
        Conexion conexion;
        DataGridViewRow seleccionado;

        public EditarMenu()
        {

            conexion = new Conexion();
            InitializeComponent();
            RecargarTabla();

        }

        #region botones

        private void borrar_Click(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                int id = int.Parse(seleccionado.Cells[0].Value.ToString());
                conexion.borrarComida(id);
                seleccionado = null;
                RecargarTabla();
            }
        }       

        private void salir_click(object sender, EventArgs e)
        {
            salir();
        }

        private void AgregarComida_Click(object sender, EventArgs e)
        {
            AgregarComida agregarComida = new AgregarComida(this);
            agregarComida.ShowDialog();
        }

        #endregion


        #region filtros

        private void textBoxFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxFiltrar.Text;
            bool esVegetariano = checkBoxVegetariano.Checked;
            bool esSinTACC = checkBoxSinTACC.Checked;

            dataGridView1.DataSource = conexion.CargarTablaComida(filtro, esVegetariano, esSinTACC);
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string filtro = textBoxFiltrar.Text;
            bool esVegetariano = checkBoxVegetariano.Checked;
            bool esSinTACC = checkBoxSinTACC.Checked;

            dataGridView1.DataSource = conexion.CargarTablaComida(filtro, esVegetariano, esSinTACC);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string filtro = textBoxFiltrar.Text;
            bool esVegetariano = checkBoxVegetariano.Checked;
            bool esSinTACC = checkBoxSinTACC.Checked;

            dataGridView1.DataSource = conexion.CargarTablaComida(filtro, esVegetariano, esSinTACC);
        }

        #endregion

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

       
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {
                //Para evitar multiselección

                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    dr.Selected = false;
                }

                //Para seleccionar
                dataGridView1.Rows[e.RowIndex].Selected = true;
                seleccionado = dataGridView1.Rows[e.RowIndex];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                int id = int.Parse(seleccionado.Cells[0].Value.ToString());
                EditarComida editarComida = new EditarComida(id, this);
                editarComida.Show();
                seleccionado = null;
                RecargarTabla();
            }
        }
    }
}
