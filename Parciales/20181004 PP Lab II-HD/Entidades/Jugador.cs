using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura { get { return this.altura; } }
        public float Peso { get { return this.peso; } }
        public Posicion Posicion { get { return this.posicion; } }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append($"Altura: {this.Altura}, Peso: {this.Peso}kg, Posicicion: {this.Posicion}");
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            double imc = 0;
            imc = this.Peso / (Math.Pow(this.Altura, 2));
            if (imc > 18.5 && imc <= 25)
            {
                return true;
            }
            return false;
        }

        public override bool ValidarAptitud()
        {
            if (ValidarEstadoFisico())
            {
                return this.Edad < 40;
            }
            return false;
        }
    }
}