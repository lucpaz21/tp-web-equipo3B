using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;



namespace Dominio
{
    public class Articulo
    {
        private int _idArticulo;
        private string _codArticulo;
        private string _nombre;
        private string _descripcion;
        private decimal _precio;

        //private Marca _marca;
        //private Categoria _categoria;
        private Imagen _imagen;

        public Articulo()
        {
            //Marca = new Marca();
            //Categoria = new Categoria();
        }

        public int IDArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }

        public string codArticulo
        {
            get { return _codArticulo; }
            set { _codArticulo = value; }
        }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public Marca Marca { get; set; }

        public string Descripcion { get { return _descripcion; } set {  _descripcion = value; } }

        public  Categoria Categoria { get; set;}

        public Imagen Imagen { get; set; }

        public decimal Precio 
        { 
            get 
            {
                return _precio; 
            }

            set
            {
                if (value >= 0) 
                    _precio = value;
            }

        }

    }
}
