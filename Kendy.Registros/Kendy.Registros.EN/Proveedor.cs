using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Proveedor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Empresa { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string CorreoElectronico { get; set; }

        public string NIT { get; set; }

        public int NumeroDeRegistro { get; set; }

        public Proveedor () { }

        public Proveedor (int pId, string pNombre, string pApellido, string pEmpresa, string pDireccion, string pTelefono, string pCorreoElectronico,
            string pNIT, int pNumeroDeRegistro)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Empresa = pEmpresa;
            Direccion = pDireccion;
            Telefono = pTelefono;
            CorreoElectronico = pCorreoElectronico;
            NIT = pNIT;
            NumeroDeRegistro = pNumeroDeRegistro;
        }
    }
}
