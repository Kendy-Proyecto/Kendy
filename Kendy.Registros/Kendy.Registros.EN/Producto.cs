using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public string FamiliaProducto {get; set; }

        public DateTime FechaCaducacion { get; set; }

        public DateTime FechaIngreso { get; set; }

        public float Precio { get; set; }

        public string Categoria { get; set; }

        public int Unidades { get; set; }

        public string Disponibilidad { get; set; }

        public Producto () { }

        public Producto(int pId, string pNombre, string pMarca, string pFamiliaProducto, DateTime pFechaCaducacion, DateTime pFechaIngreso,
            float pPrecio, string pCategoria, int pUnidades, string pDisponibilidad)
        {
            Id = pId;
            Nombre = pNombre;
            Marca = pMarca;
            FamiliaProducto = pFamiliaProducto;
            FechaCaducacion = pFechaCaducacion;
            FechaIngreso = pFechaIngreso;
            Precio = pPrecio;
            Categoria = pCategoria;
            Unidades = pUnidades;
            Disponibilidad = pDisponibilidad;
        }

    }
}
