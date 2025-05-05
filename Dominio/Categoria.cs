using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        private int _id;
        private string _nombre;

        public Categoria() { }

        public int Id 
        { 
            get 
            { 
                return _id; 
            } 
            set 
            {
                if (value > 0) _id = value;
            } 
        }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public override string ToString() 
        {
            return _nombre;
        }
    }


} 
