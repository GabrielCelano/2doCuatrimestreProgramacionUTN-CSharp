using System;

namespace Entidades
{

    #region Consigna
    // Crear exception personalizada.
    #endregion
    public class DirectorioNoCreadoException : Exception
    {
        public DirectorioNoCreadoException() : base("El directorio no existe, por lo tanto se creara") { }
    }
}
