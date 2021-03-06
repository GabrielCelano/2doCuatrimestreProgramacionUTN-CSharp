using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio64
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;
        public Caja Caja1 { get { return this.caja1; } }
        public Caja Caja2 { get { return this.caja2; } }
        public List<string> Clientes { get { return this.clientes; } }

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            this.clientes = new List<string>();
        }

        public void AsignarCaja()
        {
            //int aux1 = this.Caja1.FilaClientes.Count;
            //int aux2 = this.Caja2.FilaClientes.Count;
            Console.WriteLine("Asignando cajas...");

            foreach (string item in this.Clientes)
            {
                if (this.Caja1.FilaClientes.Count < this.Caja2.FilaClientes.Count)
                {
                    caja1.FilaClientes.Add(item);
                }
                else
                {
                    caja2.FilaClientes.Add(item);
                }

                Thread.Sleep(1000);
            }

        }
    }
}
