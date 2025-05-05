using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Vouchers
    {
        private string _CodVoucher;
        private int _IdCliente;
        private string _Fecha;
        private int _IdArticulo;


        public Vouchers()
        {
        }

        public string CodArticulo
        {
            get { return _CodVoucher; }
            set { _CodVoucher = value; }

        }

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public int IdArticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }
    
    }
}
