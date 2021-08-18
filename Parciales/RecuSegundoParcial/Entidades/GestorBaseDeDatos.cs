using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestorBaseDeDatos<T> : IGuardar<T> where T:AutoF1
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public GestorBaseDeDatos()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        public void Guardar(T tipo)
        {
            int horaLlegada = DateTime.Now.Hour;
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO resultados(escuderia, posicion, horaLlegada) VALUES(@escuderia ,@posicion, @horaLlegada)";
            comando.Parameters.AddWithValue("@escuderia", tipo.Escuderia);
            comando.Parameters.AddWithValue("@posicion", tipo.Posicion);
            comando.Parameters.AddWithValue("@horaLlegada", horaLlegada);


            this.Ejecutar();
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
