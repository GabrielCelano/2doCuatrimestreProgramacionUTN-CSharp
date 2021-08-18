using Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class GolDelSiglo
    {
        private Thread hiloRelato;
        public void IniciarJugada()
        {
            if (this.hiloRelato == null || !this.hiloRelato.IsAlive)
            {
                this.hiloRelato = new Thread(Relato.VictorHugoMorales);
                this.hiloRelato.Start();
            }
            else
            {
                throw new JugadaActivaException();
            }
        }

        public void CerrarApp()
        {
            if(!object.ReferenceEquals(this.hiloRelato, null))
            this.hiloRelato.Abort();
        }
    }
}
