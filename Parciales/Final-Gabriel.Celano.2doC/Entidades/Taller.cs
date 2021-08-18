using System;
using System.Collections.Generic;


namespace Entidades
{

    #region Consigna
    /*

        a.	Es estática.
        b.	Crear el delegado AtenderClientes que reciba un cliente
        c.	Crear un evento de tipo AtenderCliente.
        d.	El constructor estático hará las siguientes tareas:

                i.	 Llenará la variable ListaClientes consultando a la base de datos
                ii.	 Instanciar al mecánico con la información que deseen.
                iii. Instanciar al administrativo con la información que deseen.
                iv.	 Subscribirá al evento los siguientes manejadores en el siguiente orden:
                        1.	del administrativo, el método Atender.
                        2.	 del mecánico, el método Atender.
                        3.	 del administrativo, el método FinalizarAtencion.

        e.	El método PaseElSiguiente invocará al evento y le enviará el cliente recibido como parámetro.

     
     */
    #endregion

    public delegate void AtenderCliente(Cliente unCliente);
    public static class Taller
    {
        static event AtenderCliente eventoAtender;

        static Administrativo administrativo;
        static List<Cliente> listaClientes;
        static Mecanico mecanico;

        static Taller()
        {
            listaClientes = ManejadorSql.ObtenerClientes();

            mecanico = new Mecanico(39958895, "Celano", "Gabriel");
            administrativo = new Administrativo("Aylen", "Cabano");

            eventoAtender += Administrativo.Atender;
            eventoAtender += Mecanico.Atender;
            eventoAtender += Administrativo.FinalizarAtencion;
        }

        public static Administrativo Administrativo
        {
            get { return administrativo; }
        }

        public static List<Cliente> ListaClientes
        {
            get { return listaClientes; }
        }

        public static Mecanico Mecanico
        {
            get { return mecanico; }
        }

        public static void PaseElSiguiente(Cliente c)
        {
            if (!object.ReferenceEquals(eventoAtender, null))
                eventoAtender.Invoke(c);
        }
    }
}
