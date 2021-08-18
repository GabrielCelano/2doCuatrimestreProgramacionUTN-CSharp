using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class CentroDeVacunacion
    {
        private List<Paciente> paciente;

        public List<Paciente> Pacientes
        {
            get { return this.paciente; }
        }

        public CentroDeVacunacion()
        {
            this.paciente = new List<Paciente>();
        }
        public CentroDeVacunacion(List<Paciente> pacientes)
        {
            this.paciente = pacientes;
        }
    }
}
