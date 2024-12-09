using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsPOO.Entidades
{
    public class Comic : Producto
    {
        private string _autor;
        private TipoComic _tipoComic;

        public Comic()
        {
        }

        public Comic(string descripcion, decimal precio, int stock, string autor, TipoComic tipoComic) : base(descripcion, precio, stock)
        {
            _autor = autor;
            this._tipoComic = tipoComic;
        }

        public string? Autor
        {
            get { return _autor; }
            set
            {
                _autor = value;  
            }
        }
        public TipoComic? tipoComic
        {
            get { return _tipoComic; }
            set
            {
                _tipoComic = (TipoComic)value;
            }
        }

    }
}
