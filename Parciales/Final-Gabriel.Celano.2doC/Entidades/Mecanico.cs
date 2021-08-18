using System.Threading;


namespace Entidades
{
    #region Consigna

    /*
     
     a.	Heredará de PersonalTaller e implementará la interfaz ISerializable.
     b.	El método Atender recibirá un cliente, hará un Sleep de 1.5 segundos. 
        Luego agregará a la lista AtendidoPor de Cliente ESTA instancia de mecánico.


     */

    #endregion
    public class Mecanico : PersonalTaller, ISerializable
    {
        private int dni;

        public Mecanico() { }
        public Mecanico(int dni, string apellido, string nombre) : base(apellido, nombre)
        {
            this.dni = dni;
        }
        public int DNI
        {
            get { return this.dni; }
        }

        public override void Atender(Cliente c)
        {
            Thread.Sleep(1500);
            c.AtendidoPor.Add(this);
        }
    }
}
