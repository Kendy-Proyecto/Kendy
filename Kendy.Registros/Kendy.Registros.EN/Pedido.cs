using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Pedido
    {
        public int Id { get; set; }

        public int MarcaId { get; set; }

        public int EmpleadoId { get; set; }

        public Pedido() { }
        
        public Pedido (int pId, int pMarcaId, int pEmpleadoId)
        {
            Id = pId;
            MarcaId = pMarcaId;
            EmpleadoId = pEmpleadoId;
        }

    }
       
}
