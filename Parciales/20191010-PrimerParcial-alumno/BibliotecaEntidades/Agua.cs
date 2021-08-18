using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaEntidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400;
        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }

        public int ServirMedida(int medida)
        {
            int medidaRetorno;
            if (medida <= this.Contenido)
            {
                medidaRetorno = medida;
            }
            else 
            {
                medidaRetorno = this.Contenido;
            }

            return this.Contenido -= medidaRetorno;
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
        }

        protected override string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.GenerarInforme());
            sb.AppendLine($"Medida: {Agua.MEDIDA}");
            return sb.ToString();
        }
    }
}