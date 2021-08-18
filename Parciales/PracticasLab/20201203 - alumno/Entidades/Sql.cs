using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sql
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public Sql()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        public List<string> LeerRegistrosCompleto()
        {
            comando.CommandText = "SELECT id, alumno, entrada FROM dbo.log";

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                List<string> lista = new List<string>();
                while (oDr.Read())
                {
                    int id;
                    int.TryParse(oDr["id"].ToString(), out id);
                    string alumno = oDr["alumno"].ToString();
                    string entrada = oDr["entrada"].ToString();

                    string aux = string.Format($"ID: {id} | Alumno: {alumno} | Entrada: {entrada}");
                    lista.Add(aux);
                }

                return lista;
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

        public void Insert(string str)
        {
            comando.Parameters.Clear();
            comando.CommandText = "INSERT INTO dbo.log(entrada,alumno) VALUES(@entrada, @alumno)";
            comando.Parameters.AddWithValue("@entrada", str);
            comando.Parameters.AddWithValue("@alumno", "Gabriel Celano");

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
