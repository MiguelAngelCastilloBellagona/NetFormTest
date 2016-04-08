using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms1
{
    class Elemento
    {
        #region Constructores

        public Elemento(String nombre, int cantidad)
        {
            _nombre = nombre;
            _cantidad = cantidad;
        }

        #endregion //Constructores

        #region Atributos

        private String _nombre;
        private int _cantidad;

        #endregion //Atributos

        #region Propiedades públicas

        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        #endregion //Propiedades públicas


    }
}
