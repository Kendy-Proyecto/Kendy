using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
   public  class DetalleDeFactura   
    {
        public int Id { set; get; }

        public float Monto { set; get; }

     public int Unidades { set; get; }

            public int FacturaId { set; get; }

            public string NombreMarca { set; get; }

            public string FormaDePago { set; get; }

        public DetalleDeFactura() { }

        public DetalleDeFactura(int pId, float pMonto, int pUnidades, int pFacturaId, string pNombreMarca, string pFormaDePago)
        {
            Id = Id;

            Monto = Monto;

            Unidades = Unidades;

            FacturaId = FacturaId;

            NombreMarca = NombreMarca;

            FormaDePago = FormaDePago;

        }

    }
}
