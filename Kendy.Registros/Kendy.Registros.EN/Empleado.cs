using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public Empleado() { }

        public Empleado(int pId, string pNombre, string pApellido, string pGenero, string pDUI, string pTelefono, string pUsuario, string pContrasenia)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Genero = pGenero;
            DUI = pDUI;
            Telefono = pTelefono;
            Usuario = pUsuario;
            Contrasenia = pContrasenia;

        }
    }
}
