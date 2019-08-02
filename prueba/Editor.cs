using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace prueba
{
    public partial class Editor : UserControl
    {
        Form1 form1;

        public Editor(Form1 form1)
        {
            this.form1 = form1;
            conexion = new Conexion();
            InitializeComponent();
            cantidad = 0;
            recargar();
            actualizarEventos();
        }

        #region Propiedades
        Conexion conexion;
        int cantidad;
        bool precionado = false;
        bool dejarMover = true;
        Point inicial;
        Point final;
        Item seleccionado;


        public int plantilla { get; internal set; }
        #endregion
                     
        /// <summary>
        /// recorre los controles y a todos los item le da sus eventos
        /// </summary>
        public void actualizarEventos()
        {
            this.panel.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Item))).ToList().ForEach(q =>
            {
                this.DarEventos(q as Item);
            }
            );
        }

        /// <summary>
        /// coloca al panel en el tamaño fijado y trae todas las mesas
        /// </summary>
        public void recargarPlano()
        {
            cargarTrackBar();
            this.panel = conexion.cargarPlano(plantilla, panel);
            recargar();

        }

        /// <summary>
        /// muestra todos los controles cargados
        /// </summary>
        public void mostrar()
        {
            this.Controls.Cast<Control>().Where(q => q.GetType().Equals(typeof(Item))).ToList().ForEach(q =>
            {
                q.Show();
            });

        }

        /// <summary>
        /// actualiza los elementos
        /// </summary>
        public void recargar()
        {
            this.panel.Controls.Clear();
            conexion.cargarMesas(this, plantilla);
            this.panel.SendToBack();            
            actualizarEventos();
        }
                
        /// <summary>
        /// verifica que tecla tocamos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void tocarBoton(object sender, KeyEventArgs e)
        {
            Control control = (Control)sender;
            
            if (precionado)
            {
                if (e.KeyCode == Keys.R)
                {                   
                    rotarSeleccionado();
                    seleccionado.rotarEstado();
                }
                else if (e.KeyCode == Keys.D)
                {
                    if (seleccionado != null)
                    {
                        borrarControl(seleccionado);
                        recargarPlano();
                    }
                }

                
            }
        }

        public void itemPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;


            if (!precionado) inicial = new Point(control.Location.X, control.Location.Y);
            precionado = true;
            seleccionado = (Item)control;
            seleccionado.BringToFront();
        }

        private void item_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            precionado = true;
            inicial = new Point(control.Location.X, control.Location.Y);
            
            crearItem(control);            
        }

        public void item_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            Control mouse = new Control();
            mouse.Location = e.Location;
            if (precionado)
            {
                if (dejarMover)
                {
                    seleccionado.Top = e.Y + control.Top - (seleccionado.Height / 2);
                    seleccionado.Left = e.X + control.Left - (seleccionado.Width / 2);
                }
            }

            if (seleccionado != null)
            {
                if (seleccionado.index == 0)
                {
                    if (!sePuedeColocar())
                    {
                        seleccionado.BackColor = Color.Red;                        
                    }
                    else
                    {
                        dejarMover = true;
                        seleccionado.BackColor = Color.Green;
                    }
                }
                else
                {
                    if (!sePuedeMover())
                    {
                        seleccionado.BackColor = Color.Red;
                        mouse.Location = new Point(e.X, e.Y);
                        if(!estaEnPlano(mouse))dejarMover = false;
                    }
                    else
                    {
                        dejarMover = true;
                        seleccionado.BackColor = Color.Green;
                    }
                }
            }

        }

        public void item_MouseUp(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;

            precionado = false;
            final = control.Location;
            if (seleccionado != null)
            {
                
                //elemento recien creado
                if (seleccionado.index == 0)
                {
                    if (!sePuedeColocar()) borrarControl(seleccionado);
                    else
                    {
                        //si no tiene index le colocamos uno y lo guardamos
                        seleccionado.darIndex(cantidad);

                        //arreglamos posicion
                        int x = seleccionado.Location.X - panel.Location.X;
                        int y = seleccionado.Location.Y - panel.Location.Y;
                        seleccionado.Location = new Point(x, y);

                        //agregamos al panel
                        this.panel.Controls.Add(seleccionado);
                        cantidad += 1;

                        //guardamos en base de datos
                        conexion.agregarMesa(seleccionado, plantilla);
                        recargarPlano();
                    }
                }           
                //moviendo elemento existente
                else
                {
                    if (!sePuedeMover())
                    {
                        seleccionado.Location = inicial;
                    }
                    else
                    {
                        conexion.editarMesa(seleccionado, plantilla);
                        recargarPlano();
                    }
                }
                seleccionado.BackColor = SystemColors.ActiveCaption;
            }


        }
        
        /// <summary>
        /// elimina un elemento de la lista de controles
        /// </summary>
        /// <param name="control"></param>
        public void borrarControl(Control control)
        {
            this.Controls.Remove(control);
            this.panel.Controls.Remove(control);
            conexion.borrarMesa(seleccionado, plantilla);
        }

        /// <summary>
        /// entrega los eventos para mover un item
        /// </summary>
        /// <param name="pictureBox"></param>
        public void DarEventos(PictureBox pictureBox)
        {
            pictureBox.MouseDown += itemPanel_MouseDown;
            pictureBox.MouseUp += item_MouseUp;
            pictureBox.MouseMove += item_MouseMove;

        }
        
        /// <summary>
        /// invierte las proporciones del elemento seleccionado
        /// </summary>
        /// <param name="alto"></param>
        /// <param name="ancho"></param>
        public void cambiarAltoPorAncho(int alto, int ancho)
        {
            if ((seleccionado.Height == alto) && (seleccionado.Width == ancho))
            {
                seleccionado.Height = ancho;
                seleccionado.Width = alto;
            }
            else
            {
                seleccionado.Height = alto;
                seleccionado.Width = ancho;
            }
        }
        
        /// <summary>
        ///rota el item seleccionado del obj seleccionado 
        /// </summary>
        public void rotarSeleccionado()
        {
            int ancho = seleccionado.Width;
            int alto = seleccionado.Height;

            Image image = seleccionado.Image;

            image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            cambiarAltoPorAncho(alto, ancho);
            seleccionado.Image = image;

            if (seleccionado.Tag.Equals("Pared")) seleccionado.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        /// <summary>
        /// crea un item para ser arrastrado
        /// </summary>
        /// <param name="control"></param>
        public void crearItem(Control control)
        {
            seleccionado = new Item();
            DarEventos(seleccionado);
            seleccionado.BackColor = Color.Transparent;
            seleccionado.Image = (control as PictureBox).Image;
            seleccionado.Location = control.Location;
            seleccionado.SizeMode = PictureBoxSizeMode.StretchImage;

            #region tamaños
            Size mesaNormal = new Size(40, 40);
            Size MesaGrande = new Size(80, 80);
            Size MesaRectangular = new Size(60, 40);
            Size silla = new Size(20, 20);
            Size pared = new Size(100, 10);
            Size mesita = new Size(30, 30);
            Size TablaBar = new Size(120, 20);
            #endregion

            switch (control.Tag)
            {
                case "Mesa Blanca 4":
                    seleccionado.Size = mesaNormal;                    
                    break;

                case "Mesa Negra 4":
                    seleccionado.Size = mesaNormal;
                    break;

                case "Mesa Roja 4":
                    seleccionado.Size = mesaNormal;
                    break;

                case "Mesa Blanca 6":
                    seleccionado.Size = MesaRectangular;
                    break;

                case "Mesa Negra 6":
                    seleccionado.Size = MesaRectangular;
                    break;

                case "Tabla Bar":
                    seleccionado.Size = TablaBar;
                    break;                

                case "Pared":
                    seleccionado.Size = pared;
                    break;               
            }

            seleccionado.Tag = control.Tag;

            seleccionado.Show();
            this.Controls.Add(seleccionado);
            seleccionado.BringToFront();
        }
        
        #region controles
        /// <summary>
        /// verifica si se puede colocar el control
        /// </summary>
        /// <returns></returns>
        public bool sePuedeColocar()
        {
            return ((estaEnArea(panel, seleccionado)) && !existeElemento());
        }
                     
        /// <summary>
        /// verifica que movamos dentro del plano sin superponer Items
        /// </summary>
        /// <returns></returns>
        public bool sePuedeMover()
        {
            return estaEnPlano(seleccionado) && !existeElemento();
        }


        /// <summary>
        /// verifica si un control esta sobre otro o no
        /// </summary>
        /// <param name="control"></param>
        /// <param name="imagen"></param>
        /// <returns>retorna true si estan superpuestas y false en caso contrario</returns>
        public bool estaEnArea(Control control, Control imagen)
        {
            if ((control == null) || (imagen == null)) return false;
            //marco
            int CampoYMinima = control.Location.Y;
            int CampoXMinima = control.Location.X;
            int CampoYMaxima = control.Location.Y + control.Height;
            int CampoXMaxima = control.Location.X + control.Width;

            int imagenXMinima = imagen.Location.X;
            int imagenYMinima = imagen.Location.Y;
            int imagenXMaxima = imagen.Location.X + imagen.Width;
            int imagenYMaxima = imagen.Location.Y + imagen.Height;

            //esta adentro si el minimo es mayor o igual y si el maximo es menor o igual
            if ((CampoXMinima <= imagenXMinima) && (CampoYMinima <= imagenYMinima) && (CampoXMaxima >= imagenXMaxima) && (CampoYMaxima >= imagenYMaxima)) return true;
            else return false;
        }

        /// <summary>
        /// verifica si estamos moviendo bien el item. lo vamos a usar con los items que ya existen
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public bool estaEnPlano(Control control)
        {
            if (control == null) return false;

            int CampoYMinima = 0;
            int CampoXMinima = 0;
            int CampoYMaxima = panel.Height;
            int CampoXMaxima = panel.Width;
            

            int imagenXMinima = control.Location.X;
            int imagenYMinima = control.Location.Y;
            int imagenXMaxima = control.Location.X + control.Width;
            int imagenYMaxima = control.Location.Y + control.Height;

            //esta adentro si el minimo es mayor o igual y si el maximo es menor o igual
            if ((CampoXMinima <= imagenXMinima) && (CampoYMinima <= imagenYMinima) && (CampoXMaxima >= imagenXMaxima) && (CampoYMaxima >= imagenYMaxima)) return true;
            else return false;
        }

        /// <summary>
        /// verifica que no se pisen entre elementos
        /// </summary>
        /// <returns></returns>
        public bool existeElemento()
        {
            List<Control> controles =
                this.panel.Controls.OfType<Control>().ToList<Control>().FindAll(q => q.GetType().Equals(typeof(Item)));
            controles.Remove(seleccionado);

            foreach (Control control in controles)
            {

                if (estaEnRango(control))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// verifica que cuando movamos no vayamoss a colocar una pieza sobre otra
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private bool estaEnRango(Control control)
        {
            if (seleccionado == null) return false;


            int CampoYMinima = control.Location.Y;
            int CampoXMinima = control.Location.X;
            int CampoYMaxima = control.Location.Y + control.Height;
            int CampoXMaxima = control.Location.X + control.Width;
            int CampoXMedia = CampoXMaxima - control.Location.X / 2;
            int CampoYMedia = CampoYMaxima - control.Location.Y / 2;

            int imagenXMinima = seleccionado.Location.X;
            int imagenYMinima = seleccionado.Location.Y;
            int imagenXMaxima = seleccionado.Location.X + seleccionado.Width;
            int imagenYMaxima = seleccionado.Location.Y + seleccionado.Height;
            int imagenXMedia = imagenXMaxima - seleccionado.Width / 2;
            int imagenYMedia = imagenYMaxima - seleccionado.Height / 2;

            if ((CampoXMinima <= imagenXMinima) && (CampoXMaxima >= imagenXMaxima) && (CampoYMinima <= imagenYMinima) && (CampoYMaxima >= imagenYMaxima)) return true;

            else if ((CampoYMinima <= imagenYMinima) && (CampoYMaxima >= imagenYMinima) && (CampoXMinima <= imagenXMinima) && (CampoXMaxima >= imagenXMinima)) return true;
            else if ((CampoXMinima <= imagenXMaxima) && (CampoXMaxima >= imagenXMaxima) && (CampoYMinima <= imagenYMaxima) && (CampoYMaxima >= imagenYMaxima)) return true;
            else if ((CampoXMinima <= imagenXMinima) && (CampoXMaxima >= imagenXMinima) && (CampoYMinima <= imagenYMaxima) && (CampoYMaxima >= imagenYMaxima)) return true;
            else if ((CampoXMinima <= imagenXMaxima) && (CampoXMaxima >= imagenXMaxima) && (CampoYMinima <= imagenYMinima) && (CampoYMaxima >= imagenYMinima)) return true;

            else if ((CampoXMinima <= imagenXMinima) && (CampoXMaxima >= imagenXMaxima) && (CampoYMinima >= imagenYMinima) && (CampoYMaxima <= imagenYMaxima)) return true;
            else if ((imagenXMinima <= CampoXMinima) && (imagenXMaxima >= CampoXMaxima) && (imagenYMinima >= CampoYMinima) && (imagenYMaxima <= CampoYMaxima)) return true;


            else if ((CampoXMinima >= imagenXMinima) && (CampoXMinima <= imagenXMaxima) && (CampoYMinima >= imagenYMinima) && (CampoYMaxima <= imagenYMaxima)) return true;
            else if ((CampoXMaxima >= imagenXMinima) && (CampoXMaxima <= imagenXMaxima) && (CampoYMinima >= imagenYMinima) && (CampoYMaxima <= imagenYMaxima)) return true;

            else if ((imagenXMinima >= CampoXMinima) && (imagenXMinima <= CampoXMaxima) && (imagenYMinima >= CampoYMinima) && (imagenYMaxima <= CampoYMaxima)) return true;
            else if ((imagenXMaxima >= CampoXMinima) && (imagenXMaxima <= CampoXMaxima) && (imagenYMinima >= CampoYMinima) && (imagenYMaxima <= CampoYMaxima)) return true;

            else if ((CampoXMinima >= imagenXMinima) && (CampoXMaxima <= imagenXMaxima) && (CampoYMinima >= imagenYMinima) && (CampoYMinima <= imagenYMaxima)) return true;
            else if ((CampoXMinima >= imagenXMinima) && (CampoXMaxima <= imagenXMaxima) && (CampoYMaxima >= imagenYMinima) && (CampoYMaxima <= imagenYMaxima)) return true;

            else return false;
        }
        #endregion

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int alto = trackBarAltura.Value * 15 + (trackBarAltura.Value / 10) * 15;
            int ancho = trackBarAncho.Value * 15 + (trackBarAncho.Value / 10) * 15;

            if (alto > conexion.mayorY(plantilla))
            {
                if (ancho > conexion.mayorX(plantilla))
                {
                    mostrarValoresTrackBar();
                    conexion.editarValores(plantilla, trackBarAltura, trackBarAncho);
                    recargarPlano();
                }
                else trackBarAncho.Value = int.Parse(textBoxAncho.Text);

            }
             else trackBarAltura.Value = int.Parse(textBoxAlto.Text); 
            
        }

        /// <summary>
        /// coloca los valores de los trackbar en los text box
        /// </summary>
        public void mostrarValoresTrackBar()
        {
            textBoxAlto.Text = trackBarAltura.Value.ToString();
            textBoxAncho.Text = trackBarAncho.Value.ToString();
        }

        private void Editor_Resize(object sender, EventArgs e)
        {
            recargarPlano();           
        }
       
        /// <summary>
        /// busca en la base de datos el valor de los track bar
        /// </summary>
        public void cargarTrackBar()
        {
            conexion.cargarTrackBar(plantilla, trackBarAltura, trackBarAncho);
            mostrarValoresTrackBar();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            form1.button1_Click(sender, e);
        }
    }
}
