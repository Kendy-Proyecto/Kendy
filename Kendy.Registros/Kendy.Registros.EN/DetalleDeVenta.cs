using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class DetalleDeVenta
    {
        public int Id { get; set; }
        public string Producto { get; set;}
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Descuento { get; set; }
        public float PrecioConDescuento { get; set; }
        public DateTime Fecha { get; set;}
        public int VentaId { get; set;}
        public DetalleDeVenta () { }
        public DetalleDeVenta(int pId, string pProducto, int pCantidad, float pPrecio, float pDescuento, float pPrecioDeDescuento, DateTime pFecha, int pVentaId)
        {
            Id = pId;
            Producto = pProducto;
            Cantidad = pCantidad;
            Precio = pPrecio;
            Descuento = pDescuento;
            PrecioConDescuento = pPrecioDeDescuento;
            Fecha = pFecha;
            VentaId = pVentaId;
        }
    }
}
