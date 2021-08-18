using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio64
{
    public class Caja
    {
        private List<string> filaClientes;
        public Caja()
        {
            this.filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get { return this.filaClientes; }
            set { this.filaClientes = value; }
        }

        public void AtenderClientes()
        {
            foreach (String item in this.filaClientes)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {item}");
                Thread.Sleep(2000);
            }
        }
    }
}
