using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Cerveza : Botella
    {
        const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio ,contenidoML)
        {
            
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int medidaRetorno;

            if (Cerveza.MEDIDA <= this.Contenido)
            {
                medidaRetorno = (MEDIDA*80)/100;
            }
            else
            {
                medidaRetorno = this.Contenido;
            }

            return this.Contenido -= medidaRetorno;
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine($"Medida: {Cerveza.MEDIDA}");
            sb.AppendLine($"Tipo: {this.tipo}");
            return sb.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
    }
}