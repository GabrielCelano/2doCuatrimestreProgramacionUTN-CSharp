using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaSegundoParcialProg
{
    public delegate void MiDelegado(string mensaje);
    public class UnaClase
    {
        public event MiDelegado Evento;
        public UnaClase() 
        {
            Evento += Mostrar;
            Evento += metodo1;
            Evento.Invoke("Mostrar");
        }


        public void Mostrar(string mensaje)
        {
            Console.WriteLine("Hola");
        }
        public string Mostrar1(string mensaje)
        {
            Console.WriteLine("Hola");
            return mensaje;
        }
        public void metodo1(object o)
        {
            Console.WriteLine("metodo1");
        }
        
    }
}
