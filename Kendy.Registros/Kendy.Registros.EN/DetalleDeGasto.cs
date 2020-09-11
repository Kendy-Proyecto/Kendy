using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
     public class DetalleDeGasto 
    {
      public int Id { get; set; }

        public string comentario { get; set; }

        public float Monto { get; set; }

        public int GastoId { get; set; }

        public DetalleDeGasto() { }

        public DetalleDeGasto(int pId, string pcomentario, float pMonto, int pGastoId)
        {
            Id = Id;

            comentario = pcomentario;

            Monto = pMonto;

            GastoId = GastoId;
        }
    }
}
