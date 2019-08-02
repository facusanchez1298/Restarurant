using prueba.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prueba
{
    class Conexion
    {

        #region tablas
        string tablaPanel = "create table if not exists panel(" +
                            "alto int," +
                            "ancho int," +
                            "plantilla int);";

        string tablaMesa = "create table if not exists Mesa(" +
                                    "numero integer," +
                                    "dia int," +
                                    "y int," +
                                    "x int," +
                                    "alto int," +
                                    "ancho int," +
                                    "tag varchar," +
                                    "ocupada boolean," +
                                    "llegada varchar default ''," +
                                    "turno varchar," +
                                    "rotado int," +
                                    "primary key(dia, numero, turno) );";      

        string tablaPedido = "create table if not exists Pedido(" +
                                     "numeroPedido int," +
                                     "mesa int," +
                                     "turnoPedido varchar," +
                                     "FOREIGN KEY(mesa) REFERENCES mesa(numero));";
       
        string tablaComida = "create table if not exists Comida(" +
                                    "id_comida integer primary key autoincrement ," +
                                    "nombre varchar," +
                                    "vegetariano boolean," +
                                    "sinTacc boolean," +
                                    "precio float);";

        string tablaPedidoComida = "create table if not exists Pedido_Comida(" +
                                    "numeroPedido int," +
                                    "turnoPedido Varchar," +
                                    "id_comida int," +
                                    "cantidad int," +
                                    "plantilla int," +
                                    "primary key(numeroPedido, id_comida, turnoPedido, plantilla)," +
                                    "foreign key(numeroPedido) references pedido(numeroPedido)," +
                                    "foreign key(id_comida) references comida(id_comida));";

        string tablaMozo = "create table if not exists Mozo(" +
                                    "nombre varchar," +
                                    "id integer primary key," +
                                    "mañana boolean," +
                                    "tarde boolean, " +
                                    "noche boolean);";
        #endregion

        #region propiedades
        /// <summary>
        /// el objeto que se encarga de manejar la conexion con la base de datos
        /// </summary>
        SQLiteConnection connection;

        /// <summary>
        /// el objeto que se encarga de ejecutar los comandos que le pasemos
        /// </summary>
        SQLiteCommand command;

        /// <summary>
        /// lo utilizamos para adapatar contenido a la tabla
        /// </summary>
        SQLiteDataAdapter dataAdapter;

        /// <summary>
        /// lo usamos para pasarle datos a una tabla
        /// </summary>
        DataSet dataSet;

        #endregion

        #region conectar, desconectar y crear

        /// <summary>
        /// conectamos al objeto connection, ahora ya estamos conectados a la base de datos
        /// </summary>
        private void conectar()
        {

            try
            {
                this.connection = new SQLiteConnection("Data Source = datos.restaurant");
                this.connection.Open();
                this.connection.DefaultTimeout = 1;
                dataSet = new DataSet();
            }
            catch (Exception ex)
            {
                throw new Exception("no pudo realizarse la conexion" + ex);
            }
        }

        /// <summary>
        /// desconectamos al objeto connection, cerramos comunicacion con la base de datos
        /// </summary>
        private void desconectar()
        {
            try
            {
                this.connection.Close();
            }
            catch (Exception)
            {
                throw new Exception("no puso realizarse la desconexion");
            }
        }

        /// <summary>
        /// crea el archivo que va a ser la base de datos y todas las tablas
        /// </summary>
        /// <param name="nombre">nombre del archico. por defecto esta datos.grupoDeTrabajo</param>
        public void crearBaseDeDatos(string nombre = "datos.restaurant")
        {
            if (!File.Exists(nombre))
            {
                SQLiteConnection.CreateFile("datos.restaurant");
            }

            try
            {
                //abrimos coneccion
                conectar();

                //preparamos un objeto que va a ejecutar todo el comando
                command = new SQLiteCommand(tablaPanel + tablaMesa + tablaPedido + tablaComida + tablaPedidoComida + tablaMozo, this.connection);

                //ejecutamos el comando
                command.ExecuteNonQuery();

                //desconectamos el objeto
                command.Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                //cerramos la coneccion
                desconectar();
            }

        }
        #endregion

        #region borrar cosas
        /// <summary>
        /// borra un mozo
        /// </summary>
        /// <param name="index">id del mozo a borrar</param>
        internal void BorrarMozo(int index)
        {
            try
            {

                conectar();

                string sql = "delete from Mozo where id = " + index;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// borra una comida del menu
        /// </summary>
        /// <param name="id">id de la comida a eliminar</param>
        internal void borrarComida(float id)
        {
            try
            {
                conectar();
                string sql = "delete from comida where id_comida = " + id;
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// borra una mesa
        /// </summary>
        /// <param name="mesa">mesa a borrar</param>
        /// <param name="plantilla">plantilla donde estamos trabajando</param>
        public void borrarMesa(Item mesa, int plantilla)
        {
            try
            {

                conectar();

                string sql = "delete from mesa where numero = " + mesa.index + " and dia = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// borra un pedido realizado
        /// </summary>
        /// <param name="datos">ventana desde la cual lo borramos</param>
        /// <param name="id_comida">id de la comida que vamos a sacar</param>
        internal void quitarUnPedido(Datos datos, int id_comida)
        {
            try
            {

                int Pedido = datos.numeroPedido;
                string turno = datos.padre.turno;
                conectar();

                string sql = "update pedido_Comida set cantidad = cantidad - 1" +
                             " where numeroPedido =" + Pedido + "" +
                             " and turnoPedido = '" + turno + "'" +
                             " and id_comida = " + id_comida + ";";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                sql = "delete from pedido_comida where cantidad = 0";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        
        /// <summary>
        /// borra todos los pedidos de una mesa
        /// </summary>
        /// <param name="datos"></param>
        internal void quitarPedidos(Datos datos)
        {
            try
            {

                int Pedido = datos.numeroPedido;
                string turno = datos.padre.turno;
                conectar();

                string sql = "update pedido_Comida set cantidad = 0" +
                             " where numeroPedido =" + Pedido + "" +
                             " and turnoPedido = '" + turno + "'";


                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                sql = "delete from pedido_comida where cantidad = 0";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();


                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        #endregion

        #region guardar Cosas
        /// <summary>
        /// guarda las medidas que va a tener el plano
        /// </summary>
        /// <param name="ancho">ancho del plano</param>
        /// <param name="alto">alto del plano </param>
        /// <param name="plantilla">plantilla a la cual pertenece el plano</param>
        internal void guardarMedidas(string ancho, string alto, int plantilla)
        {
            try
            {
                conectar();
                string sql = "insert into panel values (" + alto + ", " + ancho + ", " + plantilla + ")";
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda una mesa
        /// </summary>
        /// <param name="control"> mesa </param>
        /// <param name="pestaña"> pestaña del modo edicion </param>
        public void agregarMesa(Item control, int pestaña)
        {
            try
            {
                //buscamos las cosas que nos importan
                int dia = pestaña;
                int numero = nroMesa(dia);
                int y = control.Location.Y;
                int x = control.Location.X;
                int alto = control.Height;
                int ancho = control.Width;
                string tag = control.Tag.ToString();
                bool ocupada = false;
                int rotado = control.getEstado();

                conectar();

                string sql = "insert into mesa(numero, dia, y, x, alto, ancho, tag, ocupada, turno, rotado) values" +
                         "(" + numero + "," + dia + "," + y + "," + x + "," + alto + "," + ancho + ",'" + tag + "','" + ocupada + "', 'Mañana'," + rotado + ");";
                sql += "insert into mesa(numero, dia, y, x, alto, ancho, tag, ocupada, turno, rotado) values" +
                         "(" + numero + "," + dia + "," + y + "," + x + "," + alto + "," + ancho + ",'" + tag + "','" + ocupada + "', 'Tarde'," + rotado + ");";
                sql += "insert into mesa(numero, dia, y, x, alto, ancho, tag, ocupada, turno, rotado) values" +
                         "(" + numero + "," + dia + "," + y + "," + x + "," + alto + "," + ancho + ",'" + tag + "','" + ocupada + "', 'Noche'," + rotado + ");";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// libera una mesa
        /// </summary>
        /// <param name="mesa">mesa a liberar</param>
        /// <param name="plantilla">plantilla en la cual se almaceno esa mesa</param>
        internal void agregarSalida(Item mesa, int plantilla)
        {
            try
            {

                conectar();

                string sql = "update mesa set llegada = ''" +
                    "  where numero = " + mesa.index + " and dia = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda un nuevo pedido en la DB
        /// </summary>
        /// <param name="padre">ventana desde la cual abrimos esta</param>
        /// <param name="id_comida">id de la comida que se pidio</param>
        /// <param name="cantidad">cantidad que se pidio</param>
        internal void agregarPedido(Datos padre, int id_comida, int cantidad, int plantilla)
        {
            try
            {
                int Pedido = padre.numeroPedido;
                string turno = padre.padre.turno;
                conectar();

                string sql = "insert into Pedido_Comida values(" + Pedido + ",'" + turno + "', " + id_comida + ", " + cantidad + "," + plantilla + ")";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception)
            {
                int Pedido = padre.numeroPedido;
                string turno = padre.padre.turno;
                conectar();

                string sql = "update pedido_Comida set cantidad = cantidad +1" +
                             " where numeroPedido =" + Pedido + "" +
                             " and turnoPedido = '" + turno + "'" +
                             " and id_comida = " + id_comida + ";";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// guarda una nueva comida en la base de datos
        /// </summary>
        /// <param name="nombre">nombre de la comida</param>
        /// <param name="vegetariano">true si es vegetariana, false en caso contrario</param>
        /// <param name="sinTACC">true si es sintacc, false en caso contrari</param>
        /// <param name="precio">precio del producto</param>
        internal void AgregarComida(string nombre, bool vegetariano, bool sinTACC, float precio)
        {
            try
            {
                conectar();

                string sql = "insert into Comida values(null ,'" + nombre + "','" + vegetariano + "', '" + sinTACC + "', " + precio + ")";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// agrega un mozo en la base de datos
        /// </summary>
        /// <param name="nombre">nombre del mozo</param>
        /// <param name="estaALaMañana">true si trabaja a la mañana, false si no</param>
        /// <param name="estaALaTarde">true si trabaja a la tarde, false si no</param>
        /// <param name="estaALaNoche">true si trabaja a la noche, false si no</param>
        internal void agregarMozo(string nombre, bool estaALaMañana, bool estaALaTarde, bool estaALaNoche)
        {
            try
            {
                conectar();

                string sql = "insert into Mozo values ('" + nombre + "', null, '" + estaALaMañana + "','" + estaALaTarde + "','" + estaALaNoche + "')";

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        #endregion

        #region cargarTablas
        
        /// <summary>
        /// carga en el datagrid todas las mesas en el plano
        /// </summary>
        /// <param name="dataGridView">donde vamos a cargar todo</param>
        /// <param name="plantilla">plantilla sobre la cual trabajamos</param>
        /// <param name="turno">turno en el cual estamos</param>
        public void cargarTablaMesas(DataGridView dataGridView, int plantilla, string turno)
        {
            try
            {
                conectar();
                string sql = "select numero as 'Mesa', ocupada as 'Ocupada', llegada " +
                    "from mesa " +
                    "where dia = " + plantilla +
                    " and tag != 'Pared' and " +
                    "tag != 'Tabla Bar' and " +
                    "tag != 'Tabla Cocina' and " +
                    "tag != 'Mesita' and " +
                    "turno = '" + turno + "'";
                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet = new DataSet();
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];

                dataGridView.DataSource = dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// cargar todas las comidas
        /// </summary>
        /// <returns>un data table con todas las comidas disponibles</returns>
        internal DataTable CargarTablaComida()
        {
            try
            {
                conectar();
                string sql = "select * from Comida ";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet = new DataSet();
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];


                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        
        /// <summary>
        /// carga todas las comidas filtradas
        /// </summary>
        /// <param name="nombre">nombre por el cual filtramos</param>
        /// <param name="vegetariano">true si es vegeratiano false si no</param>
        /// <param name="sinTACC">true si es sintacc false si no</param>
        /// <returns></returns>
        internal DataTable CargarTablaComida(string nombre, bool vegetariano, bool sinTACC)
        {
            try
            {
                conectar();
                string sql;



                if (!vegetariano && !sinTACC) sql = "select * from Comida where nombre like '%" + nombre + "%'";
                else if ((!vegetariano) && (sinTACC)) sql = "select * from Comida where nombre like '%" + nombre + "%' and sinTACC = '" + sinTACC + "'";
                else if ((vegetariano) && (!sinTACC)) sql = "select * from Comida where nombre like '%" + nombre + "%' and vegetariano = '" + vegetariano + "'";
                else sql = "select * from Comida where nombre like '%" + nombre + "%' and vegetariano = '" + vegetariano + "' and sinTACC = '" + sinTACC + "'";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet = new DataSet();
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];


                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }       

        /// <summary>
        /// carga todos los pedidos de una mesa
        /// </summary>
        /// <param name="numeroMesa">numero de la mesa que hace los pedidos</param>
        /// <param name="turno">turno en el cual estamos</param>
        /// <returns></returns>
        internal DataTable cargarTablaPedido(int numeroMesa, string turno, int plantilla)
        {
            try
            {
                conectar();
                string sql = "select pedido_comida.numeroPedido, pedido_comida.id_comida, comida.nombre, comida.precio, pedido_comida.cantidad " +
                    "from  pedido_comida, comida " +
                             "where pedido_comida.numeroPedido = " + numeroMesa +
                             " and comida.id_comida = pedido_comida.id_comida" +
                             " and pedido_comida.turnoPedido = '" + turno + "'" +
                             " and pedido_comida.plantilla = " + plantilla;

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet = new DataSet();
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt.Columns.Add("Total", typeof(float));

                foreach (DataGridViewRow item in dt.Rows)
                {
                    float precio = float.Parse(item.Cells["precio"].Value.ToString());
                    int cantidad = int.Parse(item.Cells["cantidad"].Value.ToString());
                    item.Cells["total"].Value = precio * cantidad;
                }


                dt = dataSet.Tables[0];


                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// carga todos los mozos filtrados
        /// </summary>
        /// <param name="nombre">filtrar por nombre</param>
        /// <param name="mañana">true si trabaja a la mañana false en caso contrario</param>
        /// <param name="tarde">true si trabaja a la tarde false en caso contrario</param>
        /// <param name="noche">true si trabaja a la noche false en caso contrario</param>
        /// <returns>DataTable</returns>
        internal DataTable cargarTablaMozos(string nombre, bool mañana, bool tarde, bool noche)
        {
            try
            {
                conectar();
                string sql, tMañana, tTarde, tNoche;

                tMañana = (mañana) ? mañana.ToString() : "";
                tTarde = (tarde) ? tarde.ToString() : "";
                tNoche = (noche) ? noche.ToString() : "";

                if (!mañana && !tarde && !noche) sql = "select * from Mozo where nombre like '%" + nombre + "%'";
                else sql = "select * from Mozo where nombre like '%" + nombre + "%' and mañana like '%" + tMañana + "' and tarde like '%" + tTarde + "' and noche like '%" + tNoche + "'";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet = new DataSet();
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];


                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// carga todos los mozos disponibles en un combobox segun su turno
        /// </summary>
        /// <param name="turno">de que turno los queremos?</param>
        /// <returns></returns>
        internal DataTable CargarComboBoxMozos(string turno)
        {
            try
            {

                conectar();
                string sql = "select * from Mozo where " + turno.ToLower() + " = 'True'";

                dataAdapter = new SQLiteDataAdapter(sql, connection);

                dataSet = new DataSet();
                dataSet.Reset();

                DataTable dt = new DataTable();
                dataAdapter.Fill(dataSet);

                dt = dataSet.Tables[0];
                return dt;
            }
            catch (Exception e)
            {

                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        #endregion

        #region cargar cosas
        /// <summary>
        /// carga las mesas en un form
        /// </summary>
        /// <param name="ver"></param>
        /// <param name="plantilla"></param>
        internal void cargarMesas(Ver ver, int plantilla)
        {
            conectar();
            String consulta = "select * from mesa where dia = " + plantilla;
            SQLiteCommand command = new SQLiteCommand(consulta, connection);
            try
            {
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    int numero = lector.GetInt32(0);
                    int dia = lector.GetInt32(1);
                    int y = lector.GetInt32(2);
                    int x = lector.GetInt32(3);
                    int alto = lector.GetInt32(4);
                    int ancho = lector.GetInt32(5);
                    string tag = lector.GetString(6);
                    bool ocupado = bool.Parse(lector.GetString(7));
                    int estado = lector.GetInt32(10);

                    DateTime dateTime;

                    if (!lector.GetString(8).Equals(""))
                    {
                        dateTime = DateTime.Parse(lector.GetString(8));
                    }
                    else dateTime = new DateTime();

                    Item item = new Item();
                    item.darIndex(numero);
                    item.Llegada = dateTime;
                    item.Location = new Point(x, y);
                    item.Size = new Size(ancho, alto);
                    item.Tag = tag;
                    item.estaOcupado(ocupado);
                    item.BackColor = SystemColors.ActiveCaption;
                    item.darEstado(estado);
                    item.Show();


                    switch (tag)
                    {
                        case "Mesa Blanca 4":
                            item.Image = Resources.mesa_de_madera_4_;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;

                        case "Mesa Roja 4":
                            item.Image = Resources.mesa_roja_4;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;

                            break;

                        case "Mesa Negra 4":
                            item.Image = Resources.mesa_negra_4;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;



                        case "Mesa Negra 6":
                            item.Image = Resources.mesa_negra_6;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;

                        case "Mesa Blanca 6":
                            item.Image = Resources.mesa_blanca_6_personas;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;

                        case "Pared":
                            item.Image = Resources.pared_roja;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;

                        case "Tabla Bar":
                            item.Image = Resources.tabla_bar;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }


                    //rota la imagen
                    if (item.getEstado() == 2)
                    {
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (item.getEstado() == 3)
                    {
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (item.getEstado() == 4)
                    {
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    ver.planoVer.Controls.Add(item);

                }
                ver.planoVer.SendToBack();
                lector.Close();
                command.Connection.Close();

            }
            catch (Exception e)
            {
                command.Connection.Close();
                throw new Exception("no se pudo realizar la coneccion: " + e);
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// carga las mesas en un userControl.Editor
        /// </summary>
        /// <param name="editor"></param>
        /// <param name="v"></param>
        internal void cargarMesas(Editor editor, int plantilla)
        {
            conectar();
            String consulta = "select * from mesa where dia = " + plantilla + " and turno = 'Mañana'";
            SQLiteCommand command = new SQLiteCommand(consulta, connection);
            try
            {
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {

                    int numero = lector.GetInt32(0);
                    int dia = lector.GetInt32(1);
                    int y = lector.GetInt32(2);
                    int x = lector.GetInt32(3);
                    int alto = lector.GetInt32(4);
                    int ancho = lector.GetInt32(5);
                    string tag = lector.GetString(6);
                    bool ocupado = bool.Parse(lector.GetString(7));
                    int estado = lector.GetInt32(10);
                    DateTime dateTime;

                    if (!lector.GetString(8).Equals(""))
                    {
                        dateTime = DateTime.Parse(lector.GetString(8));
                    }
                    else dateTime = new DateTime();

                    Item item = new Item();
                    item.darIndex(numero);
                    item.Llegada = dateTime;
                    item.Llegada = dateTime;
                    item.Location = new Point(x, y);
                    item.Size = new Size(ancho, alto);
                    item.Tag = tag;
                    item.estaOcupado(ocupado);
                    item.BackColor = SystemColors.ActiveCaption;
                    item.Show();
                    item.darEstado(estado);

                    switch (tag)
                    {
                        case "Tabla Bar":
                            item.Image = Resources.tabla_bar;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Mesa Roja 4":
                            item.Image = Resources.mesa_roja_4;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Mesa Negra 4":
                            item.Image = Resources.mesa_negra_4;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Mesa Blanca 4":
                            item.Image = Resources.mesa_de_madera_4_;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Mesa Negra 6":
                            item.Image = Resources.mesa_negra_6;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Mesa Blanca 6":
                            item.Image = Resources.mesa_blanca_6_personas;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Pared":
                            item.Image = Resources.pared_roja;
                            item.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                    }

                    //rota la imagen
                    if (item.getEstado() == 2)
                    {
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (item.getEstado() == 3)
                    {
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    else if (item.getEstado() == 4)
                    {
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        item.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    }
                    editor.panel.Controls.Add(item);
                }
                lector.Close();
                command.Connection.Close();
            }
            catch (Exception e)
            {
                command.Connection.Close();
                throw new Exception("no se pudo realizar la coneccion: " + e);
            }
            finally
            {
                command.Connection.Close();
            }
        }
        
        /// <summary>
        /// carga los datos de la comida a editar en la ventada editar comida
        /// </summary>
        /// <param name="editarComida"> ventana donde vamos a cargar</param>
        /// <param name="id">id de la comida a editar</param>
        internal void cargarComida(EditarComida editarComida, int id)
        {
            try
            {

                conectar();

                string sql = "select * from comida where id_comida = " + id;

                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    editarComida.textBoxNombre.Text = lector.GetString(1);
                    editarComida.checkBoxSinTACC.Checked = bool.Parse(lector.GetString(2));
                    editarComida.checkBoxVegetariano.Checked = bool.Parse(lector.GetString(3));
                    editarComida.textBoxPrecio.Text = lector.GetFloat(4).ToString();
                }

                command.Connection.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// carga en la ventana mozo el mozo a editar
        /// </summary>
        /// <param name="editarMozo">ventana donde vamos a cargar los datos</param>
        /// <param name="id">mozo a editar</param>
        internal void cargarTablaMozos(EditarMozo editarMozo, int id)
        {
            try
            {

                conectar();

                string sql = "select * from Mozo where id = " + id;

                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    editarMozo.textBoxNombre.Text = lector.GetString(0);
                    editarMozo.checkBoxMañana.Checked = lector.GetBoolean(2);
                    editarMozo.checkBoxTarde.Checked = lector.GetBoolean(3);
                    editarMozo.checkBoxNoche.Checked = lector.GetBoolean(4);
                }

                command.Connection.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// asigna el valor a los trackbar
        /// </summary>
        /// <param name="plantilla">plantilla en la cual estamos trabajando</param>
        /// <param name="trackBarAltura">trackbar al que se asignaremos la altura</param>
        /// <param name="trackBarAncho">trackBar que se va a encargar del ancho</param>
        internal void cargarTrackBar(int plantilla, TrackBar trackBarAltura, TrackBar trackBarAncho)
        {
            try
            {

                conectar();

                string sql = "select * from panel where plantilla = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    trackBarAltura.Value = lector.GetInt32(0);
                    trackBarAncho.Value = lector.GetInt32(1);
                }

                command.Connection.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// devuelve un plano cargado con todas las mesas
        /// </summary>
        /// <param name="plantilla">plantilla en la cual estamos trabajando</param>
        /// <param name="planoVer">plano en el cual vamos a cargar las mesas</param>
        /// <returns>plano con las mesas cargadas</returns>
        internal Plano cargarPlano(int plantilla, Plano planoVer)
        {
            try
            {

                conectar();

                string sql = "select * from panel where plantilla = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    planoVer.Height = lector.GetInt32(0) * 15 + (lector.GetInt32(0) / 10) * 15;
                    planoVer.Width = lector.GetInt32(1) * 15 + (lector.GetInt32(1) / 10) * 15;
                    //Mensaje.mensajeError((lector.GetInt32(0) * 15 + (lector.GetInt32(0) / 10) * 15).ToString());
                }

                return planoVer;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        #endregion

        #region editar cosas
        /// <summary>
        /// marca una mesa como ocupada o desocupada
        /// </summary>
        /// <param name="mesa">mesa que se va a ocupar</param>
        /// <param name="plantilla">plantilla donde estamos trabajando</param>
        /// <param name="estado">true para ocuparla, false para desocuparla</param>
        /// <param name="turno">turno donde estamos trabajando</param>
        internal void cambiarEstadoMesa(Item mesa, int plantilla, bool estado, String turno)
        {
            try
            {
                conectar();
                string sql = "update mesa set ocupada = '" + estado + "'" +
                    "  where numero = " + mesa.index + " and dia = " + plantilla;

                if (!estado) sql += " ; delete from pedido where " +
                        "numeroPedido = " + mesa.index + " and " +
                        "mesa = " + mesa.index + " and " +
                        "turnoPedido = '" + turno + "'";
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// edita la posicion de una mesa
        /// </summary>
        /// <param name="mesa">mesa que estamos editando</param>
        /// <param name="plantilla">plantilla en la que estamos trabajando</param>
        internal void editarMesa(Item mesa, int plantilla)
        {
            try
            {

                conectar();

                string sql = "update mesa set y = " + mesa.Location.Y + ", x = " + mesa.Location.X + " ," +
                    "alto = " + mesa.Height + ", ancho = " + mesa.Width + ", rotado = " + mesa.getEstado() +
                    "  where numero = " + mesa.index + " and dia = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// marca el horario en el que se ocupo una mesa
        /// </summary>
        /// <param name="now">momento del dia en el que se ocupo</param>
        /// <param name="mesa">mesa que se ocupo</param>
        /// <param name="plantilla">plantilla en la cual esta la mesa</param>
        internal void EditarIngreso(DateTime now, Item mesa, int plantilla)
        {
            try
            {

                conectar();

                string sql = "update mesa set llegada = '" + now.ToLongTimeString() +
                    "'  where numero = " + mesa.index + " and dia = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// cambia los valores de las medidas del panel en la base de datos
        /// </summary>
        /// <param name="plantilla">plantilla en la que estamos trabajando</param>
        /// <param name="trackBarAltura">track bar que marque la altura</param>
        /// <param name="trackBarAncho">trackBar que marque el ancho</param>
        internal void editarValores(int plantilla, TrackBar trackBarAltura, TrackBar trackBarAncho)
        {
            try
            {

                conectar();

                string sql = "update panel " +
                    "set alto = " + trackBarAltura.Value +
                    ", ancho = " + trackBarAncho.Value +
                    " where plantilla = " + plantilla;


                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    trackBarAltura.Value = lector.GetInt32(0);
                    trackBarAncho.Value = lector.GetInt32(1);
                }

                command.Connection.Close(); ;
            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// edita una comida del menu
        /// </summary>
        /// <param name="id">id de la comida a editar</param>
        /// <param name="nombre">nuevo nombre de la comida</param>
        /// <param name="precio">nuevo precio</param>
        /// <param name="sinTacc">true si es sintacc, false en caso contrario </param>
        /// <param name="vegetariano">true si es vegetariano, false en caso contrario</param>
        internal void editarComida(int id, string nombre, string precio, bool sinTacc, bool vegetariano)
        {
            try
            {

                conectar();

                string sql = "update comida set nombre = '" + nombre + "', precio = " + precio + " ," +
                    "vegetariano = '" + vegetariano + "', sintacc = '" + sinTacc + "' where  id_comida = " + id;
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();

                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// edita un mozo
        /// </summary>
        /// <param name="id">id del mozo a editar</param>
        /// <param name="nombre">nuevo nombre</param>
        /// <param name="estaALaMañana">true si trabaja a la mañana, false en caso contrario</param>
        /// <param name="estaALaTarde">true si trabaja a la tarde, false en caso contrario</param>
        /// <param name="estaALaNoche">true si trabaja a la noche, false en caso contrario</param>
        internal void editarMozo(int id, string nombre, bool estaALaMañana, bool estaALaTarde, bool estaALaNoche)
        {
            try
            {
                conectar();

                string sql = "update comida set nombre = '" + nombre + "', mañana = '" + estaALaMañana + "' , " +
                    "tarde = '" + estaALaTarde + "', noche = '" + estaALaNoche + "' where  id = " + id;

                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }
        #endregion

        /// <summary>
        /// devuelve el numero de mesas dentro de una plantilla de edicion
        /// </summary>
        /// <param name="plantilla"></param>
        /// <returns></returns>
        private int nroMesa(int plantilla)
        {
            conectar();
            string sql = "SELECT max(numero) FROM Mesa where dia = " + plantilla + " ORDER BY numero DESC";
            command = new SQLiteCommand(sql, connection);

            SQLiteDataReader lector = command.ExecuteReader();
            try
            {
                if (lector.Read())
                {
                    int numero = lector.GetInt32(0) + 1;
                    lector.Close();
                    command.Connection.Close();
                    desconectar();
                    return numero;
                }
                else return 1;

            }
            catch (Exception)
            {
                lector.Close();
                command.Connection.Close();
                desconectar();
                return 1;

            }

        }       

        /// <summary>
        /// verifica si ya se habian configurado las medidas del plano
        /// </summary>
        /// <param name="plantilla">plantilla en la cual estamos trabajando</param>
        /// <returns>true si hay medidas, false si no hay</returns>
        internal bool hayMedidas(int plantilla)
        {
            try
            {

                conectar();

                string sql = "select * from panel where plantilla = " + plantilla;

                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader sQLiteDataReader = command.ExecuteReader();

                if (sQLiteDataReader.Read())
                {
                    command.Connection.Close();
                    return true;
                }
                else return false;



            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }       
        
        /// <summary>
        /// busca la mesa que se encuentre mas abajo
        /// </summary>
        /// <param name="plantilla">plantilla en la que estamos trabajando</param>
        /// <returns> valor y del objeto que se encuentre mas abajo en el plano</returns>
        public int mayorY(int plantilla)
        {
            try
            {
                int numero = 0;
                conectar();
                string sql = "select max(y + alto) from mesa where dia = " + plantilla;
                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();

                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        numero = lector.GetInt32(0);
                    }
                }
                command.Connection.Close();
                return numero;

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

        /// <summary>
        /// busca la mesa que se encuentre mas a la derecha en el plano
        /// </summary>
        /// <param name="plantilla">planilla donde estamos trabajando</param>
        /// <returns>variable x del objeto que se encuentre mas a la derecha en el plano</returns>
        public int mayorX(int plantilla)
        {
            try
            {
                int numero = 0;
                conectar();
                string sql = "select max(x + ancho) from mesa where dia = " + plantilla;
                command = new SQLiteCommand(sql, connection);
                SQLiteDataReader lector = command.ExecuteReader();
                while (lector.Read())
                {
                    if (!lector.IsDBNull(0))
                    {
                        numero = lector.GetInt32(0);
                    }
                }
                command.Connection.Close();
                return numero;

            }
            catch (Exception e)
            {
                throw new Exception("Error: " + e);
            }
            finally
            {
                desconectar();
            }
        }

       

       

    }
}