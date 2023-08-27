﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCapaDato = new CD_Venta();

        public bool Registrar(Venta venta, DataTable DetalleVenta, out string Mensaje)
        {
            return  objCapaDato.Registrar(venta, DetalleVenta, out Mensaje);

        }
    }
}
