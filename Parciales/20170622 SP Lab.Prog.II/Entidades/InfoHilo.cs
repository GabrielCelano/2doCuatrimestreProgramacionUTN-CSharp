using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        static Random randomizer;

        static InfoHilo()
        {
            InfoHilo.randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback)
        {
            this.hilo = new Thread(Ejecutar);

            this.id = id;
            this.callback = callback;

            this.hilo.Start();
        }

        private void Ejecutar()
        {
            int aux = InfoHilo.randomizer.Next(1, 6); 
            Thread.Sleep(aux * 1000);
            this.callback.RespuestaHilo(this.id);
        }
    }
}