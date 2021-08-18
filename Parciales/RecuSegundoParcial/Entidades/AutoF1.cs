using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;
        public AutoF1() { }
        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.Escuderia = escuderia;
            this.puntoPartida = puntoPartida;
            this.Velocidad = velocidad;
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        public int Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        public int UbicacionEnPista
        {
            get { return this.puntoPartida; }
            set { this.puntoPartida = value; }
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }

        public override string ToString()
        {
            return string.Format($"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}");
        }

        public void Acelerar()
        {
            this.puntoPartida += this.Velocidad;
        }
    }
}
