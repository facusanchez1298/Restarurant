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
    public partial class Mozos : Form
    {
        Conexion Conexion;
        DataGridViewRow seleccionado;

        public Mozos()
        {
            InitializeComponent();
            Conexion = new Conexion();

            recargarTabla();
        }

        public void recargarTabla()
        {
            string filtro = textBoxNombre.Text;
            bool estaALaMañana = checkBoxMañana.Checked;
            bool estaALaTarde = checkBoxTarde.Checked;
            bool estaALaNoche = checkBoxNoche.Checked;

            dataGridView1.DataSource = Conexion.cargarTablaMozos(filtro, estaALaMañana, estaALaTarde, estaALaNoche);
            dataGridView1.Columns["id"].Visible = false;
        }
        
        private bool TieneTurno()
        {
            bool estaALaMañana = checkBoxMañana.Checked;
            bool estaALaTarde = checkBoxTarde.Checked;
            bool estaALaNoche = checkBoxNoche.Checked;

            if (!estaALaMañana && !estaALaTarde && !estaALaNoche) return false;
            else return true;
        }      

        #region botones
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarMozo agregarMozo = new AgregarMozo(this);
            agregarMozo.ShowDialog();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                int index = int.Parse(seleccionado.Cells["id"].Value.ToString());
                Conexion.BorrarMozo(index);
                seleccionado = null;
                recargarTabla();
            }
        }
        #endregion

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            recargarTabla();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            recargarTabla();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            recargarTabla();
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

        private void buttonBorrar_Click_1(object sender, EventArgs e)
        {
            if(seleccionado != null)
            {
                int index = int.Parse(seleccionado.Cells["id"].Value.ToString());
                EditarMozo editarMozo = new EditarMozo(this, index);
                editarMozo.ShowDialog();
                seleccionado = null;
                recargarTabla();                
            }
        }
    }
}
