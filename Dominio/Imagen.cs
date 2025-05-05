using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Imagen
    {
        private int _idImagen;
        private string _ImagenURL;

        private Articulo _articulo;

        public Imagen() { }

        public Imagen(int id, string url, Articulo articulo)
        {
           _idImagen = id;
            _ImagenURL = url;
            _articulo = articulo;
        }

        public int IDImagen { get { return _idImagen;} set { _idImagen = value; } }
        public string ImagenURL {get { return _ImagenURL;} set { _ImagenURL = value; } }

        public Articulo Articulo { get { return _articulo; } set { _articulo = value; } }

        public override string ToString()
        {
            return ImagenURL;
        }
    }

    
    }
