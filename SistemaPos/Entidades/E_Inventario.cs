using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPos.Entidades
{
    public class E_Inventario
    {
        public int Codigo_pro {  get; set; }

        public int Cantidad_pro { get; set; }
        public string Descripcion_pro { get; set; }
        public string Codigomanual_pro { get; set; }

        public int Utilidad_pro { get; set; }
        public int Impuesto_pro { get; set; }
        public string Cabys_pro {  get; set; }
        public string Codigo_fa { get; set; }
        public decimal Pu_costo { get; set; }
        public decimal Pu_venta {  get; set; }
        public decimal Pu_descuento { get; set; }

        public DateTime FechaCrea_pro { get; set; }

        public DateTime FechaMod_pro { get; set; }
        public int Codigo_us {  get; set; }
    }
}
