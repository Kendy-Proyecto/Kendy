using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    class Informe
    {
        public int Id { get; set; }

        public string Tipo { get; set; }

        public float Gasto { get; set; }

        public float Ganancia { get; set; }

        public int EmpleadoId { get; set; }

        public DateTime Fecha { get; set; }

        public float DineroFisico { get; set; }

        public Informe(int pId, string pTipo, float pGasto, int pEmpleadoId, DateTime pFecha, float pDineroFisico)
        {
            Id = pId;
            Tipo = pTipo;
            Gasto = pGasto;
            EmpleadoId = pEmpleadoId;
            Fecha = pFecha;
            DineroFisico = pDineroFisico;

        }
    }
}
