﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public int IDProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
