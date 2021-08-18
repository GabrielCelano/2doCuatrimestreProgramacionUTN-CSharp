using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        //Campos
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        //Constructor 
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        //Metodos
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private short SetTinta(short tinta)
        {
            short aux = 0;
            if (tinta > 0)
            {
                if (this.tinta + tinta < 100)
                {
                    this.tinta = 100;
                }

                else
                {
                    this.tinta += tinta;
                }
            }

            else
            {
                if (this.tinta + tinta <= 0)
                {
                    aux += this.tinta;
                    this.tinta = 0;
                    Console.WriteLine("Necesita recargar tinta.");
                }
                else
                {
                    aux = tinta;
                    this.tinta += tinta;
                }
            }

            return aux;
        }


        public void Recargar()
        {
            while(this.tinta < 100)
            {
                this.SetTinta((short)1);
            }
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";
            //int contador = 0;
            int tinta = gasto * -1;
            //Console.WriteLine(tinta);
            gasto = SetTinta((short)tinta);
            bool validacion = false;

            for (short i = 0; i < (gasto * -1); i++)
            {
                dibujo += "*";
                validacion = true;
            }


            //Console.WriteLine(this.tinta);
            //Console.WriteLine(contador);
            return validacion;
        }
    }
}
