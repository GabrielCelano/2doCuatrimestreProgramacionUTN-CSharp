using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<List<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        public void Guardar(string archivo, List<Patente> datos)
        {
            try
            {
                foreach (Patente item in datos)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = $"INSERT INTO tabla {archivo} " +
                                          $"VALUES(@codigo)";

                    comando.Parameters.AddWithValue("@codigo", item.CodigoPatente);
                }

                this.Ejecutar();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el INSERT", ex);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public void Leer(string archivo, out List<Patente> datos)
        {
            comando.CommandText = $"SELECT * FROM {archivo}";

            try
            {
                this.Ejecutar();
                SqlDataReader oDr = comando.ExecuteReader();
                List<Patente> lista = new List<Patente>();
                Patente auxPatente = new Patente();
                while (oDr.Read())
                {
                    string AuxCodigoPatente = oDr["patente"].ToString();
                    auxPatente.CodigoPatente = AuxCodigoPatente;
                    lista.Add(auxPatente);
                }

                datos = lista;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo Leer la base de datos", ex);
            }
            finally
            {
                this.conexion.Close();
            }
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
        }
    }
}
