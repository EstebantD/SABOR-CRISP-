using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entidades
{

    public class Factura : Productos
    {
        public Factura() { }
        public DateTime Fecha_Compra { get; set; }

        public Factura(string documento, DateTime fecha_Compra, string nombre_Productos, int precio_Total)
        {
            Documento = documento;
            Fecha_Compra = fecha_Compra;
            Nombre_Producto = nombre_Productos;
            Precio_Total = precio_Total;
        }
    }

}
