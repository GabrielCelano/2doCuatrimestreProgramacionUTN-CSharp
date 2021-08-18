using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public abstract class Botella
    {
        private int capacidadML; //mililitros
        private int contenidoML;
        private string marca;
        public enum Tipo { Plastico, Vidrio }
        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            int contenido = contenidoML;
            if (capacidadML < contenido)
            {

                this.contenidoML = capacidadML;
            }

            this.capacidadML = capacidadML;
            this.contenidoML = contenido;
            this.marca = marca;
        }

        public float CapacidadLitros { get { return this.capacidadML / 1000; } }
        public int Contenido { get { return this.contenidoML; } set { this.contenidoML = value; } }
        public int PorcentajeContenido { get { return (this.contenidoML * 100) / this.capacidadML; } }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}.");
            sb.AppendLine($"Contenido: {this.Contenido} ml");
            sb.AppendLine($"Porcentaje contenido: %{this.PorcentajeContenido}");
            sb.AppendLine($"Capacidad: {this.CapacidadLitros} lt.");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
        }
    }
}