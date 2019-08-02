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
    public partial class Datos : Form, Dar
    {
        #region propiedades
        Item item;
        public Ver padre;
        Conexion conexion;
        public int numeroPedido;
        DateTime llego;
        DataGridViewRow seleccionado;
        #endregion

        public Datos()
        {            
            conexion = new Conexion();            
            InitializeComponent();
            
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "id";
        }

        public void darPadre(Ver ver)
        {
            this.padre = ver;
        }

        internal void refrescarTabla()
        {
            float total = 0;
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = conexion.cargarTablaPedido(numeroPedido, padre.turno, padre.plantilla);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;


            dataGridView1.Columns.Add("Total", "Total");

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                float precio = float.Parse(item.Cells["precio"].Value.ToString());
                int cantidad = int.Parse(item.Cells["cantidad"].Value.ToString());
                item.Cells["total"].Value = precio * cantidad;
                total += precio * cantidad; 
            }

            labelPrecio.Text = "$" + total.ToString();
        }

        public void cargarCBMozos()
        {
            comboBox1.DataSource = conexion.CargarComboBoxMozos(padre.turno);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelActual.Text = (DateTime.Now - llego).ToString(@"hh\:mm\:ss");
        }       
        
        #region botones

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            
        }

        private void hacerPedido_Click(object sender, EventArgs e)
        {
            padre.AbrirFormEnPanel<Pedido>(item, this);
        }

        private void botonOcupar(object sender, EventArgs e)
        {
            if (buttonOcupar.Text.Equals("Ocupar"))
            {
                if (comboBox1.Text == "")
                {
                    Mensaje.mensajeError("no se puede ocupar una mesa si no se define un mozo");
                }
                else
                {
                    conexion.cambiarEstadoMesa(item, padre.plantilla, true, padre.turno);
                    buttonOcupar.Text = "Desocupar";
                    buttonAgregar.Enabled = true;
                    labelLLego.Text = DateTime.Now.ToLongTimeString();
                    llego = DateTime.Now;
                    labelActual.Text = (DateTime.Now - llego).ToString();
                    timer1.Start();
                    conexion.EditarIngreso(DateTime.Now, item, padre.plantilla);
                }
            }
            else
            {
                conexion.cambiarEstadoMesa(item, padre.plantilla, false, padre.turno);
                buttonOcupar.Text = "Ocupar";
                conexion.agregarSalida(item, padre.plantilla);
                conexion.quitarPedidos(this);
                timer1.Stop();
                buttonAgregar.Enabled = false;
            }
            refrescarTabla();
        }
        #endregion

        #region heredados
        public void darPadre(Form form)
        {
            this.darPadre(form as Ver);
            refrescarTabla();
            cargarCBMozos();
        }

        public void salir()
        {
            padre.recargar();
            this.Close();
        }

        public void darItem(Item item)
        {
            this.item = item;

            if (item.ocupado)
            {
                buttonOcupar.Text = "Desocupar";
                buttonAgregar.Enabled = true;
            }
            else
            {
                buttonOcupar.Text = "Ocupar";
                buttonAgregar.Enabled = false;
            }


            if (item.Llegada != null)
            {
                llego = item.Llegada;
                labelLLego.Text = llego.ToString("HH:mm:ss");

            }
            else timer1.Stop();

            numeroPedido = item.index;

            labelNumero.Text = numeroPedido.ToString();

            
        }

        #endregion

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            
            int id_comida = int.Parse(fila.Cells["id_comida"].Value.ToString());

            conexion.quitarUnPedido(this, id_comida);

            this.refrescarTabla();

        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }
    }
}
