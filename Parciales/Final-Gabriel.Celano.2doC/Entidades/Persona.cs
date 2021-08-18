using System.Xml.Serialization;

namespace Entidades
{

    #region Consigna

    /*
        a.	El metodo ToString() devolverá un string que contendrá el " apellido , nombre "de la persona.
        b.	Esta clase será serializada, por lo tanto deberá INCLUIR las clases Cliente, Mecánico y Administrativo.

     */


    #endregion

    [XmlInclude(typeof(Cliente))]
    [XmlInclude(typeof(Mecanico))]
    [XmlInclude(typeof(Administrativo))]

    public abstract class Persona
    {
        private string apellido;
        private string nombre;

        public Persona() { }
        public Persona(string apellido, string nombre)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public override string ToString()
        {
            return string.Format($"{this.Apellido}, {this.Nombre}");
        }
    }
}
