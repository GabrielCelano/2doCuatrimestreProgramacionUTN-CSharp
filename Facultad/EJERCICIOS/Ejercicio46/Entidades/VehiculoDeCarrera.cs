using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public abstract class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string scuderia)
        {
            this.numero = numero;
            this.escuderia = scuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short CantidadCombustible { get { return this.cantidadCombustible; } set { this.cantidadCombustible = value; } }
        public bool EnCompetencia { get { return this.enCompetencia; } set { this.enCompetencia = value; } }
        public short VueltasRestantes { get { return this.vueltasRestantes; } set { this.vueltasRestantes = value; } }
        public string Escuderia { get { return this.escuderia; } set { this.escuderia = value; } }
        public short Numero { get { return this.numero; } set { this.numero = value; } }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"En competencia: {this.EnCompetencia}");
            sb.AppendLine($"Cantidad combustible: {this.CantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {this.VueltasRestantes}");
            return sb.ToString();
        }
    }
}