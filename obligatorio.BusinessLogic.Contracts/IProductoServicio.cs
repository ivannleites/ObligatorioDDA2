using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.BusinessLogic.Contracts
{
    public interface IProductoServicio
    {
        void AgregarProducto(Producto producto);
        Producto ObtenerProductoPorId(int id);
        IEnumerable<Producto> ObtenerTodosLosProductos();
        void ActualizarProducto(Producto producto);
        void EliminarProducto(int id);
        void AplicarPromocionACarrito(Carrito carrito);
    }
}