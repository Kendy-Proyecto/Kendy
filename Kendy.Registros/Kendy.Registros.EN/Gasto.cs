using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Gasto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
        public Gasto () { }
        public Gasto(int pId, DateTime pFecha, int pEmpleadoId)
        {
            Id = pId;
            Fecha = pFecha;
            EmpleadoId = pEmpleadoId;
        }
    }
}
