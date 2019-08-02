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
                                    "primary key(numeroPedido, id_comida, turnoPedido)," +
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

        public void borrarMesa(Item seleccionado, int plantilla)
        {
            try
            {

                conectar();

                string sql = "delete from mesa where numero = " + seleccionado.index + " and dia = " + plantilla;

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

        #region guardarCosas

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

        internal void agregarSalida(Item item, int plantilla)
        {
            try
            {

                conectar();

                string sql = "update mesa set llegada = ''" +
                    "  where numero = " + item.index + " and dia = " + plantilla;

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

        internal void agregarPedido(Datos padre, int id_comida, int cantidad)
        {
            try
            {
                int Pedido = padre.numeroPedido;
                string turno = padre.padre.turno;
                conectar();

                string sql = "insert into Pedido_Comida values(" + Pedido + ",'" + turno + "', " + id_comida + ", " + cantidad + ")";

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

        internal void agregarMozo(string filtro, bool estaALaMañana, bool estaALaTarde, bool estaALaNoche)
        {
            try
            {
                conectar();

                string sql = "insert into Mozo values ('" + filtro + "', null, '" + estaALaMañana + "','" + estaALaTarde + "','" + estaALaNoche + "')";

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
        public void cargarTablaMesas(DataGridView dataGridView, int dia, string turno)
        {
            try
            {
                conectar();
                string sql = "select numero as 'Mesa', ocupada as 'Ocupada', llegada " +
                    "from mesa " +
                    "where dia = " + dia +
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

        internal DataTable CargarTablaComida(string filtro, bool vegetariano, bool sinTACC)
        {
            try
            {
                conectar();
                string sql;



                if (!vegetariano && !sinTACC) sql = "select * from Comida where nombre like '%" + filtro + "%'";
                else if ((!vegetariano) && (sinTACC)) sql = "select * from Comida where nombre like '%" + filtro + "%' and sinTACC = '" + sinTACC + "'";
                else if ((vegetariano) && (!sinTACC)) sql = "select * from Comida where nombre like '%" + filtro + "%' and vegetariano = '" + vegetariano + "'";
                else sql = "select * from Comida where nombre like '%" + filtro + "%' and vegetariano = '" + vegetariano + "' and sinTACC = '" + sinTACC + "'";

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

        internal DataTable CargarTablaComida(string filtro)
        {
            try
            {
                conectar();
                string sql = "select * from Comida where nombre like '%" + filtro + "%'";

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

        internal DataTable cargarTablaPedido(int numeroPedido, string turno)
        {
            try
            {
                conectar();
                string sql = "select pedido_comida.numeroPedido, pedido_comida.id_comida, comida.nombre, comida.precio, pedido_comida.cantidad from  pedido_comida, comida  " +
                             "where pedido_comida.numeroPedido = " + numeroPedido +
                             " and comida.id_comida = pedido_comida.id_comida" +
                             " and pedido_comida.turnoPedido = '" + turno + "'";

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


        internal DataTable cargarTablaMozos(string filtro, bool mañana, bool tarde, bool noche)
        {
            try
            {
                conectar();
                string sql, tMañana, tTarde, tNoche;

                tMañana = (mañana) ? mañana.ToString() : "";
                tTarde = (tarde) ? tarde.ToString() : "";
                tNoche = (noche) ? noche.ToString() : "";

                if (!mañana && !tarde && !noche) sql = "select * from Mozo where nombre like '%" + filtro + "%'";
                else sql = "select * from Mozo where nombre like '%" + filtro + "%' and mañana like '%" + tMañana + "' and tarde like '%" + tTarde + "' and noche like '%" + tNoche + "'";

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
                            item.SizeMode = PictureBoxSizeMode.Zoom;

                            break;

                        case "Mesa Negra 4":
                            item.Image = Resources.mesa_negra_4;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;



                        case "Mesa Negra 6":
                            item.Image = Resources.mesa_negra_6;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
                            item.Click += ver.item_DoubleClick;
                            item.MouseHover += ver.Mouse_hover;
                            item.MouseLeave += ver.Mouse_Leave;
                            break;

                        case "Mesa Blanca 6":
                            item.Image = Resources.mesa_blanca_6_personas;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
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
                            item.SizeMode = PictureBoxSizeMode.Zoom;
                            break;

                        case "Mesa Negra 4":
                            item.Image = Resources.mesa_negra_4;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
                            break;

                        case "Mesa Blanca 4":
                            item.Image = Resources.mesa_de_madera_4_;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
                            break;

                        case "Mesa Negra 6":
                            item.Image = Resources.mesa_negra_6;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
                            break;

                        case "Mesa Blanca 6":
                            item.Image = Resources.mesa_blanca_6_personas;
                            item.SizeMode = PictureBoxSizeMode.Zoom;
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

        internal void ocuparMesa(Item item, int plantilla, bool estado, String turno)
        {
            try
            {
                conectar();
                string sql = "update mesa set ocupada = '" + estado + "'" +
                    "  where numero = " + item.index + " and dia = " + plantilla;

                if (!estado) sql += " ; delete from pedido where " +
                        "numeroPedido = " + item.index + " and " +
                        "mesa = " + item.index + " and " +
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

        internal void editarMesa(Item seleccionado, int plantilla)
        {
            try
            {

                conectar();

                string sql = "update mesa set y = " + seleccionado.Location.Y + ", x = " + seleccionado.Location.X + " ," +
                    "alto = " + seleccionado.Height + ", ancho = " + seleccionado.Width + ", rotado = " + seleccionado.getEstado() +
                    "  where numero = " + seleccionado.index + " and dia = " + plantilla;

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

        internal void EditarIngreso(DateTime now, Item item, int plantilla)
        {
            try
            {

                conectar();

                string sql = "update mesa set llegada = '" + now.ToLongTimeString() +
                    "'  where numero = " + item.index + " and dia = " + plantilla;

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

    }
}