using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace obligatorio.BusinessLogic.Contracts
{
    public interface ICompraServicio
    {
        void RealizarCompra(Compra compra);
        Compra ObtenerCompraPorId(int id);
        IEnumerable<Compra> ObtenerTodasLasCompras();
    }
}
