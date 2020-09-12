using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string CorreoElectronico { get; set; }

        public string Genero { get; set; }
        public string DUI { get; set; }

        public string NIT { get; set; }

        public string ConsumidorFinal { get; set; }


        public string SalonDeBelleza { get; set; }


        public int NumeroDeCompras { get; set; }
        
        public Cliente() { }

        public Cliente(int pId, string pNombre, string pApellido, string pTelefono, string pCorreoElectronico, string pGenero,
            string pDUI, string pNIT, string pConsumidorFinal, string pSalonDeBelleza, int pNumeroDeCompras)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;
            Telefono = pTelefono;
            CorreoElectronico = pCorreoElectronico;
            Genero = pGenero;
            DUI = pDUI;
            NIT = pNIT;
            ConsumidorFinal = pConsumidorFinal;
            SalonDeBelleza = pSalonDeBelleza;
            NumeroDeCompras = pNumeroDeCompras;

        }
    }
}
