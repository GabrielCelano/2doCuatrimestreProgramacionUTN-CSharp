using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder($"Estacionamiento: {e.nombre}\nCantidad de vehiculos: {e.vehiculos.Count} Espacio disponible: {e.espacioDisponible}\n");

            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
           /* foreach (Vehiculo item in estacionamiento.vehiculos)
            {
                return item == vehiculo;
            }
            return false; */ //No funciona
            return estacionamiento.vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento != vehiculo && vehiculo.Patente != "" && estacionamiento.espacioDisponible > estacionamiento.vehiculos.Count)
            {
                estacionamiento.vehiculos.Add(vehiculo);
                return estacionamiento;
            }
            return estacionamiento;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                estacionamiento.vehiculos.Remove(vehiculo);
                return vehiculo.ImprimirTicket();
            }
            return "El vehiculo no es parte del estacionamiento.";
        }
    }
}