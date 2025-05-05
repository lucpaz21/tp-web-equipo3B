using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {

        
        private int _id;
        private string _nombre;
        
        //public Marca() { }

        public int Id 
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                    _id = value;
            }
        }

        [DisplayName("Descripción")]
        public string Nombre { get { return _nombre; } set { _nombre = value; } }



        public override string ToString()
        {
            return _nombre;
        }
    }
}
