﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class BaseDeDatos : IAchivos<Paciente>
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public BaseDeDatos()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        public bool Guardar(string clausula, Paciente datos)
        {
            bool aux = false;
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO Pacientes(turno, nombre, apellido) VALUES(@turno ,@nombre, @apellido)"; // clausula
            comando.Parameters.AddWithValue("@turno", datos.Turno);
            comando.Parameters.AddWithValue("@nombre", datos.Nombre);
            comando.Parameters.AddWithValue("@apellido", datos.Apellido);

            aux = this.Ejecutar();
            return aux;
        }

        public List<Paciente> Leer(string archivo, List<Paciente> pacientes)
        {
            comando.CommandText = "SELECT turno, nombre, apellido FROM Pacientes";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();
                pacientes = new List<Paciente>();
                while (oDr.Read())
                {
                    int turno;
                    int.TryParse(oDr["turno"].ToString(), out turno);
                    string nombre = oDr["nombre"].ToString();
                    string apellido = oDr["apellido"].ToString();

                    Paciente paciente = new Paciente(turno, nombre, apellido);
                    pacientes.Add(paciente);
                }

                return pacientes;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }
        }

        private bool Ejecutar()
        {
            bool aux = false;
            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
                aux = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }
            return aux;
        }
    }
}
