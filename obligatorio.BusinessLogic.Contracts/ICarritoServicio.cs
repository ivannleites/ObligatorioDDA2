using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.BusinessLogic.Contracts
{
    public interface ICarritoServicio
    {
        void AgregarAlCarrito(Producto producto);
        void EliminarDelCarrito(Producto producto);
        IEnumerable<Producto> ObtenerArticulosDelCarrito();
        void FinalizarCompra();
    }
}
