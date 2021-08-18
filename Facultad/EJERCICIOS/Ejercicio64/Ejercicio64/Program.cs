using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            negocio.Clientes.Add("Gabriel");
            negocio.Clientes.Add("Yolanda");
            negocio.Clientes.Add("Aylen");
            negocio.Clientes.Add("Ricardo");
            negocio.Clientes.Add("Sabrina");
            negocio.Clientes.Add("Clarisa");

            Thread asignarCajas = new Thread(negocio.AsignarCaja);
            Thread atenderCaja1 = new Thread(caja1.AtenderClientes);
            Thread atenderCaja2 = new Thread(caja2.AtenderClientes); 

            atenderCaja1.Name = "Caja 1";
            atenderCaja2.Name = "Caja 2";

            asignarCajas.Start();
            asignarCajas.Join();

            atenderCaja1.Start();
            atenderCaja2.Start();
        }
    }
}
