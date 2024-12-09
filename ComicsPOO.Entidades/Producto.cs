using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComicsPOO.Entidades
{
    public class Producto
    {
        private Guid _codigo { get; set; }
        private string? _descripcion { get; set; }
        private decimal _precio { get; set; }
        private int _stock { get; set; }
        public Producto(string descripcion, decimal precio, int stock)
        {
            _codigo = Guid.NewGuid();
            _descripcion = descripcion;
            _precio = precio;
            _stock = stock;
        }

        protected Producto()
        {
        }

        public Producto(decimal precio, int stock)
        {
            Precio = precio;
            Stock = stock;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Descripciom: {_descripcion}");
            sb.AppendLine($"Codigo: {_codigo}");
            sb.AppendLine($"Precio: {_precio.ToString("C2")}");
            sb.AppendLine($"Stock: {_stock}");
            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Producto p)
            {
                return string.Equals(_descripcion, p._descripcion);
            }
            return false;
        }

        public string? Descipcion
        {
            get { return _descripcion; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    _descripcion = value;
                }
                else
                {
                    throw new ArgumentException("Descripcion es requerida");
                }
            }
        }

        public Guid Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value > 0)
                {

                    _precio = value;
                }
                else
                {
                    throw new ArgumentException("Precio debe ser mayor a cero");
                }
            }
        }

        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value > 0)
                {

                    _stock = value;
                }
                else
                {
                    throw new ArgumentException("Stock debe ser mayor a cero");
                }
            }
        }

        public override int GetHashCode()
        {
            return _codigo.GetHashCode();
        }


    }
}
