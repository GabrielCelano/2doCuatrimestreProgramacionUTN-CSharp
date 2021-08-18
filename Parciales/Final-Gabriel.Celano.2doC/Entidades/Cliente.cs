using System.Collections.Generic;
using System.Text;

namespace Entidades
{

    #region Consigna

    /*
    
     a.	Cliente hereda de Persona e implementa la interfaz ISerializable.
     b.	Su constructor con parámetros instanciará la lista. El constructor por defecto no hará nada.
     c.	El método ToString agregará el DNI al ToString() de la base

    */

    #endregion
    public class Cliente : Persona, ISerializable
    {
        private List<PersonalTaller> atendidoPor;
        private int dni;

        public Cliente() { }
        public Cliente(int dni, string apellido, string nombre) : base(apellido, nombre)
        {
            this.dni = dni;
            this.atendidoPor = new List<PersonalTaller>();
        }

        public int DNI
        {
            get { return this.dni; }
        }
        public List<PersonalTaller> AtendidoPor
        {
            get { return this.atendidoPor; }
            set { this.atendidoPor = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"\n Dni: {this.DNI}");
            return sb.ToString();
        }
    }
}
