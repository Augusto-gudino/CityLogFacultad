using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_UI
{
    public abstract class Producto
    {
        private string nombre;
        private int cantidad;

        public string Nombre
        {
            get { return nombre;}
            set { Nombre = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { Cantidad = value; }
        }


        public Producto()
        {

        }

        public Producto(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

    }
}
