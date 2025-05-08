using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Clientes
    {
        private int _ClienteId;
        private string _Documento;
        private string _NombreCliente;
        private string _ApellidoCliente;
        private string _CorreoCliente;
        private string _Direccion;
        private string _Ciudad;
        private int _Cp;

        public Clientes() { }

        public int ClienteId {  get { return _ClienteId; } set { _ClienteId = value; }}

        public string Documento { get { return _Documento; } set { _Documento = value; }}

        public string NombreCliente { get { return _NombreCliente; } set { _NombreCliente = value; }}
        
        public string ApellidoCliente { get { return _ApellidoCliente; } set { _ApellidoCliente = value; } }

        public string CorreoCliente { get { return _CorreoCliente; } set { _CorreoCliente = value; }}
        public string Direccion { get { return _Direccion; } set {_Direccion = value; }}

        public string Ciudad { get { return _Ciudad; }  set { _Ciudad = value; }}

        public int Cp { get { return _Cp; } set {_Cp = value; }}


    }
}
