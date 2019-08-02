using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public interface Dar
    {
        void darItem(Item item);

        void darPadre(Form form);
        void salir();
    }
}
