using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Factura
    {
        public int Id { get; set; }

        public float Monto { get; set; }

        public int ClienteId { get; set; }

        public int VentaId { get; set; }

        public DateTime Fecha { get; set; }

        public int EmpleadoId { get; set; }

        public Factura() { }


        public Factura(int pId, float pMonto, int pClienteId, int pVentaId, DateTime pFecha, int pEmpleadoId)
        {
            Id = pId;
            Monto = pMonto;
            ClienteId = pClienteId;
            VentaId = pVentaId;
            Fecha = pFecha;
            EmpleadoId = pEmpleadoId;
        }

    }



}
