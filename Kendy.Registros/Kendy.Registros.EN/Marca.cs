using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendy.Registros.EN
{
    class Marca
    {
        public int Id { get; set; }

        public int ProveedorId { get; set; }

        public string   Nombre { get; set; }
        
        public Marca() { }
        
        public Marca(int pId, int pProveedor, string pNombre)
        {
            Id = pId;
            ProveedorId = pProveedor;
            Nombre = pNombre;
        }
    }

}
