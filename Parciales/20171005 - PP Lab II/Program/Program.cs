using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadFinanciera;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gabriel Celano";
            Financiera financiera = new Financiera("Mi Financiera");
            PrestamoDolar pd1 = new PrestamoDolar(1500, new DateTime(2020, 11, 01),
            Prestamo.PeriodicidadDePagos.Mensual);
            PrestamoDolar pd2 = new PrestamoDolar(2000, new DateTime(2020, 12, 05),
            Prestamo.PeriodicidadDePagos.Bimestral);
            PrestamoDolar pd3 = new PrestamoDolar(2500, new DateTime(2018, 01, 01),
            Prestamo.PeriodicidadDePagos.Trimestral);
            PrestamoPesos pp1 = new PrestamoPesos(8000, new DateTime(2020, 01, 01), 20);
            PrestamoPesos pp2 = new PrestamoPesos(7000, new DateTime(2001, 10, 01), 25);
            PrestamoPesos pp3 = new PrestamoPesos(5000, new DateTime(2020, 11, 20), 20);

            financiera = financiera + pd1;
            financiera = financiera + pd2;
            financiera = financiera + pd3;
            financiera = financiera + pd3; //Préstamo repetido
            financiera = financiera + pp1;
            financiera = financiera + pp2;
            financiera = financiera + pp3;
            financiera = financiera + pp3; //Préstamo repetido
            Console.WriteLine((String)financiera);
            pd1.ExtenderPlazo(new DateTime(2017, 12, 01));
            pp1.ExtenderPlazo(new DateTime(2018, 02, 01));
            financiera.OrdenarPrestamos();
            Console.WriteLine("\n ********************ORDENADOS POR FECHA**************************");
            Console.WriteLine(Financiera.Mostrar(financiera));
            Console.ReadKey();
        }
    }
}

