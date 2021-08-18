using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PersonaDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public PersonaDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            // No hace falta ponerlo como Text, es el default
            // this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }

        public string buscar(string consulta)
        {
            //comando.CommandText = consulta;
            string aux = string.Empty;
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();

            try
            {
                
                    conexion.Open();


                SqlDataReader oDr = comando.ExecuteReader();

            
                while (oDr.Read())
                {

                    aux = oDr["apellido"].ToString();
                   
                }

                return aux;
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


        public void Insert(Persona p)
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO Personas(nombre, apellido) " +
                                  "VALUES(@nombre, @apellido)";

            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@apellido", p.Apellido);

            this.Ejecutar();
        }

        public void Update(Persona p)
        {
            comando.Parameters.Clear();
            comando.CommandText = $"UPDATE Personas " +
                                  $"SET Nombre = @nombre, Apellido = @apellido " +
                                  $"WHERE id = @id";

            comando.Parameters.AddWithValue("@nombre", p.Nombre);
            comando.Parameters.AddWithValue("@apellido", p.Apellido);
            comando.Parameters.AddWithValue("@id", p.ID);

            this.Ejecutar();
        }

        public void Delete(int id)
        {
            comando.Parameters.Clear();
            comando.CommandText = $"DELETE Personas " +
                                  $"WHERE id = @id";
            
            comando.Parameters.AddWithValue("@id", id);

            this.Ejecutar();
        }


        private void Ejecutar()
        {
            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
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
    }
}
