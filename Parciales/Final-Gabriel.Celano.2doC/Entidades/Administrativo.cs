using System.Threading;

namespace Entidades
{

    #region Consigna

    /*
        a.	Heredará de PersonalTaller.
        b.	Su método Atender hará lo siguiente:
            i.	 Pausará el thread por 1 segundo.
            ii.	 Agregará a la lista AtendidoPor del cliente recibido por parámetro la instancia de ESTE administrativo.
            iii. Llamará a la clase Archivos para Generar el ticket.

     */
    #endregion

    public class Administrativo : PersonalTaller
    {
        public Administrativo() { }
        public Administrativo(string apellido, string nombre):base(apellido, nombre) { }
        public override void Atender(Cliente c)
        {
            Thread.Sleep(1000);
            c.AtendidoPor.Add(this);
            Archivos<Cliente>.GenerarTicket(c);
        }
    }
}
