using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        //Datos alumno
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;

        //Constructor
        public Alumno(string nombre, string apellido, int legajo)
        {
            if (nombre != "" && apellido != "" && (legajo > 1000 && legajo < 9999))
            {
                this.nota1 = 0;
                this.nota2 = 0;
                this.notaFinal = 0;
                this.apellido = apellido;
                this.legajo = legajo;
                this.nombre = nombre;
            }

            else Console.WriteLine("Error al ingresar los datos!.");
        }

        //Metodos
        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            //System.Threading.Thread.Sleep(200);
            //Random final = new Random();
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = (this.nota1 + this.nota2) / 2;
            }

            else this.notaFinal = -1;
        }

        public string MostrarAlumno()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nPlantilla del alumno");
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine("Nota primer parcial: " + this.nota1);
            sb.AppendLine("Nota segundo parcial: " + this.nota2);
            sb.AppendLine("Nota final: " + this.notaFinal);
            return sb.ToString();
        }
    }
}
