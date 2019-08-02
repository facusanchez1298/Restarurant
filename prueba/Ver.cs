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
    public partial class Ver : Form
    {
        public int plantilla = 1;
        Conexion Conexion;
        public string turno;

        public Ver()
        {
            Conexion = new Conexion();
            InitializeComponent();
            Conexion.crearBaseDeDatos();
            comboBox1.SelectedIndex = 0;
            turno = comboBox1.Text;

            recargarPlano();

            
        }

        #region botones
        /// <summary>
        /// abre la ventana del editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this, plantilla);
            form1.Show();
            this.Hide();
        }
        #endregion

        #region botones de cambio de plantilla
        private void button3_Click(object sender, EventArgs e)
        {
            plantilla = 1;
            recargarPlano();
            cerrarPaneles();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            plantilla = 2;
            recargarPlano();
            cerrarPaneles();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            plantilla = 3;
            recargarPlano();
            cerrarPaneles();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            plantilla = 4;
            recargarPlano();
            cerrarPaneles();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            plantilla = 5;
            recargarPlano();
            cerrarPaneles();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            plantilla = 6;
            recargarPlano();
            cerrarPaneles();
        }


        #endregion



        public void recargarPlano()
        {
            if (!Conexion.hayMedidas(plantilla))
            {
                AgregarMedidas agregarMedidas = new AgregarMedidas(plantilla);
                agregarMedidas.ShowDialog();
            }

            this.planoVer = Conexion.cargarPlano(plantilla, planoVer);
            this.labelAlto.Text = this.planoVer.Height.ToString();
            this.labelAncho.Text = this.planoVer.Width.ToString();
            recargar();
        }
        

        /// <summary>
        /// actualiza todos los datos de la ventana
        /// </summary>
        public void recargar()
        {

            this.planoVer.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Item))).ToList().ForEach(q =>
            {
                this.planoVer.Controls.Remove(q);
            });
            Conexion.cargarMesas(this, plantilla);
            planoVer.SendToBack();
            actualizarTabla();
        }

        /// <summary>
        /// actualiza los datos de la tabla
        /// </summary>
        public void actualizarTabla()
        {
            Conexion.cargarTablaMesas(dataGridView1, plantilla, turno);
        }

        /// <summary>
        /// un temporizador para el relog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToShortDateString();
            labelDia.Text = DateTime.Now.ToString("dddd");
        }

        internal void Mouse_hover(object sender, EventArgs e)
        {            
            (sender as Item).BackColor = (sender as Item).ocupado ? Color.Red : Color.Green;
        }

        internal void Mouse_Leave(object sender, EventArgs e)
        {
            (sender as Item).BackColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// lo usamos para abrir datos y pedidos
        /// se deben poder usar ambos al mismo tiempo
        /// y deberian cerrar a mozos y menu
        /// </summary>
        /// <typeparam name="form"></typeparam>
        /// <param name="item"></param>
        public void AbrirFormEnPanel<form>(Item item) where form : Form, Dar, new() 
        {
            
            Form formulario;
            formulario = panelDatos.Controls.OfType<Form>().FirstOrDefault();

            if (formulario != null)
            {
                cerrarPaneles();
                formulario = panelDatos.Controls.OfType<form>().FirstOrDefault();
            }

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new form();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Left;
                
                panelDatos.Controls.Add(formulario);
                panelDatos.Tag = formulario;
                formulario.Show();
               

                (formulario as Dar).darItem(item);
                (formulario as Dar).darPadre(this);
                


                formulario.BringToFront();
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }


        

        internal void AbrirFormEnPanel<form>(Item item, Datos datos) where form : Pedido, new()
        {
            form formulario;
            formulario = panelDatos.Controls.OfType<form>().FirstOrDefault();
            
            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new form();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Left;
                
                panelDatos.Controls.Add(formulario);
                panelDatos.Tag = formulario;
                formulario.Show();
                formulario.FormClosed += Formulario_FormClosed;
                

                formulario.darItem(item);
                formulario.darPadre(datos);



                formulario.BringToFront();
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelDatos.AutoSize = true;
        }
        /// <summary>
        /// abre el menu y los mozos, deberia cerrar todo lo demas
        /// </summary>
        /// <typeparam name="form"></typeparam>
        internal void AbrirFormEnPanel<form>() where form : Form, new()
        {
            Form formulario;
            formulario = panelDatos.Controls.OfType<Form>().FirstOrDefault();
            

            //si hay formularios del otro tipo los cerramos

            if (formulario != null)
            {
                cerrarPaneles();
                formulario = panelDatos.Controls.OfType<form>().FirstOrDefault();
            }

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new form();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Left;

                panelDatos.Controls.Add(formulario);
                panelDatos.Tag = formulario;
                formulario.Show();
                
                formulario.BringToFront();
            }
            else
            {
                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

       

        public void cerrarPaneles()
        {
            panelDatos.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Datos)) || q.GetType().Equals(typeof(Pedido)) || q.GetType().Equals(typeof(Mozos)) || q.GetType().Equals(typeof(EditarMenu))).ToList().ForEach(q =>
            {
                (q as Form).Close();
            });
        }

        private void plano1_Click(object sender, EventArgs e)
        {
            cerrarPaneles();
            dataGridView1.BringToFront();
            recargar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ponerColorDeFondo();

            if (e.RowIndex >= 0)
            {
                int mesa = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Mesa"].Value.ToString());
                
                this.planoVer.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Item))).ToList().ForEach(q =>
                {
                    if ((q as Item).index == mesa)
                    {
                       
                        q.BackColor = Color.Green;                       
                    }
                });
            }
        }

        public void ponerColorDeFondo()
        {
            this.planoVer.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Item))).ToList().ForEach(q =>
            {   
                    q.BackColor = SystemColors.ActiveCaption;
            });
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ponerColorDeFondo();

           
            if(e.RowIndex >= 0)
            {
                int mesa = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Mesa"].Value.ToString());


                this.planoVer.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Item))).ToList().ForEach(q =>
                {
                    if((q as Item).index == mesa)
                    {                        
                        q.BackColor = Color.Green;
                        AbrirFormEnPanel<Datos>(q as Item);
                    }
                });
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<EditarMenu>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            turno = comboBox1.Text;
            recargar();
            cerrarPaneles();
        }

        private void buttonMozo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Mozos>();
        }

        private void Ver_Resize(object sender, EventArgs e)
        {

            recargarPlano();
            this.labelAlto.Text = this.planoVer.Height.ToString();
            this.labelAncho.Text = this.planoVer.Width.ToString();            
        }

        internal void item_DoubleClick(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Datos>(sender as Item);
        }

        
    }
}

