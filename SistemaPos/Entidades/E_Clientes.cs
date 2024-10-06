using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class E_Clientes
    {
        public int Codigo_cl {  get; set; }
        public string Nombre_cli {  get; set; }
        public string Identificacion_cli { get; set; }
        public string Direccion_cli { get; set; }
        public string Telefono_cli { get; set; }
        public int Codigo_us { get; set; }
    }
}
