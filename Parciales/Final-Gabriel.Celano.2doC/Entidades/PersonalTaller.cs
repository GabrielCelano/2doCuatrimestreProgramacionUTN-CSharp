namespace Entidades
{

    #region Consigna

    /*
     a.	Hereda de Persona
     b.	El metodo FinalizarAtencion recibirá un cliente, llamará al método Guardar de la clase Archivos.

     */
    #endregion
    public abstract class PersonalTaller : Persona
    {
        public PersonalTaller() { }
        public PersonalTaller(string apellido, string nombre) : base(apellido, nombre) { }

        public void FinalizarAtencion(Cliente c)
        {
            Archivos<Cliente>.Guardar(c);
        }
        public abstract void Atender(Cliente c);
    }
}
