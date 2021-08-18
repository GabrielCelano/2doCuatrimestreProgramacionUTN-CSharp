using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Dao : IArchivos<Votacion>
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        public Dao()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConection);
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }
        public bool Guardar(string rutaArchivo, Votacion objeto)
        {

            string nombreLey = objeto.NombreLey;
            short afirmativos = objeto.ContadorAfirmativo;
            short negativos = objeto.ContadorNegativo;
            short abstenciones = objeto.ContadorAbstencion;
            bool retorno = true;

            try
            {
                conexion.Open();
                //Ojo, aca va la tabla, no la BD!
                comando.CommandText = $"INSERT INTO dbo.Votaciones" +
                    $" (nombreLey,afirmativos,negativos,abstenciones,nombreAlumno)" +
                    $" VALUES ('{nombreLey}',{afirmativos},{negativos},{abstenciones},'{"Hamie Matias"}')";

                comando.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                retorno = false;
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
