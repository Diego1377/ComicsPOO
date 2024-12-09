using ComicsPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComicsPOO.Datos
{
    public class Comiqueria
    {
        private string? _nombre;
        private List<Producto>? _producto;

        public Comiqueria(string? nombre, List<Producto>? producto)
        {
            _nombre = nombre;
            _producto = new List<Producto>();
        }
        public List<Producto> Productos
        {
            get { return _producto; }
            set { _producto = value; }
        }
        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public bool ExisteProducto(Producto producto)
        {
            return _producto.Any(p => p.Descipcion == producto.Descipcion && p.Precio==producto.Precio && p.Stock==producto.Stock && p.Codigo == producto.Codigo);
        }
        public (bool exito, string mensaje) AgregarProducto(Producto producto)
        {
            if (producto != null)
            {
                if (!ExisteProducto(producto))
                {
                    _producto.Add(producto);
                    return (true, $"{producto}");

                }
                return (false, "Producto existente!!!");
            }
            return (false, "Producto nulo!!!");
        }

        public Producto? GetProducto(Guid producto)
        {
            return _producto.FirstOrDefault(p => p.GetHashCode() == producto.GetHashCode());
        }
    }
}
