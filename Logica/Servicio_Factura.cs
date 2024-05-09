using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioFactura
    {
        Datos.RepositorioFactura repositorioFactura;
        public ServicioFactura(string connectionString)
        {
             = new Datos.RepositorioFactura(connectionString);
        }
        public void Insertar(Factura factura)
        {
            repositorioFactura.Insert(factura);
        }
        public string Total_Ingresos()
        {
            int total = 0;
            foreach (var item in GetAll())
            {
                total += item.Precio_Total;
            }
            return total.ToString();
        }
        public DataTable GetAllProductos_Cliente(string documento)
        {
            return repositorioFactura.GetAllProductos_Cliente(documento);
        }
        public List<Factura> GetAll()
        {
            return repositorioFactura.GetAll();
        }
        public DataTable GetFactura()
        {
            return repositorioFactura.GetAllTabla();
        }
    }
}
