using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{

    
    public class Item  : PictureBox
    {
        public DateTime Llegada;
        public int index;
        public bool ocupado;
        int estado = 1;

        public void estaOcupado(bool ocupado)
        {
            this.ocupado = ocupado;
        }

        public void darIndex(int index)
        {
            this.index = index;
        }

        public void rotarEstado()
        {
            if (estado < 4)
            {
                estado += 1;
            }
            else estado = 1;
        }

        internal int getEstado()
        {
            return estado;
        }

        public void darEstado(int estado)
        {
            this.estado = estado;
        }
    }
}
