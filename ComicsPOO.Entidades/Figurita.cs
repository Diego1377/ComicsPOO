using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsPOO.Entidades
{
    public class Figurita:Producto
    {
        private float _altura;

        public Figurita(string descripcion, decimal precio, int stock, float altura) : base(descripcion, precio, stock)
        {
            _altura = altura;
        }
        public float? Altura
        {
            get { return _altura; }
            set
            {
                _altura = (float)value;
            }
        }
        public Figurita() : base()
        {

        }
        public Figurita(decimal precio, int stock, float altura) : base( precio, stock)
        {
            _altura = altura;
        }
       

    }
}
