using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BD<T> : IArchivos<T> where T : CentroDeVacunacion
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public BD()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }
        public bool Leer(string consulta, out T objeto)
        {
            comando.CommandText = consulta;
            bool aux = false;
            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();
                CentroDeVacunacion centroDeVacunacion = new CentroDeVacunacion();
                while (oDr.Read())
                {
                    int turno;
                    int.TryParse(oDr["turno"].ToString(), out turno);
                    string nombre = oDr["nombre"].ToString();
                    string apellido = oDr["apellido"].ToString();

                    Paciente paciente = new Paciente(apellido, nombre, turno);
                    centroDeVacunacion.Pacientes.Add(paciente);
                    aux = true;
                }
                objeto = (T)centroDeVacunacion;
                return aux;
            }
            catch (Exception ex)
            {
                throw new ArchivoInvalidoException("Error al leer base de datos", ex.InnerException);
            }
            finally
            {
                this.conexion.Close();
            }
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
