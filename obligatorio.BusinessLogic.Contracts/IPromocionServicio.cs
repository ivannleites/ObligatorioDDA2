using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obligatorio.BusinessLogic.Contracts
{
    public interface IPromocionServicio
    {
        IEnumerable<Promocion> ObtenerTodasLasPromociones();
        IEnumerable<Promocion> ObtenerPromocionesAplicables(Carrito carrito);
        void AplicarMejorPromocion(Carrito carrito);
    }
}
