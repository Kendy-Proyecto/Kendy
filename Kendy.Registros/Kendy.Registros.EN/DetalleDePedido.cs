using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class DetalleDePedido
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }

        public float Monto { get; set; }

        public int Unidades { get; set; }

        public string NombreDelProducto { get; set; }

        public int fecha { get; set; }

        public int FechaPrevistaLlegada { get; set; }

        public DetalleDePedido() { }

        public DetalleDePedido(int PId, int pPedidoId, float PMonto, int pUnidades, string pNombreDelProducto, int pFecha, int pFechaPrevistaLlegada)
        {
            Id = Id;

            PedidoId = PedidoId;

            Monto = Monto;

            Unidades = Unidades;

            NombreDelProducto = NombreDelProducto;

            fecha = fecha;

            FechaPrevistaLlegada = FechaPrevistaLlegada;
        }
    }

}
