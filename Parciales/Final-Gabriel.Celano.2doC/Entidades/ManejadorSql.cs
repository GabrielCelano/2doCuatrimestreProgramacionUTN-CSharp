using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{

    #region Consigna
    /*
       a.	Es una clase estática. 
       b.	El constructor estático instanciará el objeto SqlConnection  y seteará la connectionString:
                    “Data Source=.; Initial Catalog=Final_Lab2021; Integrated Security=True”;
       c.	ObtenerClientes deberá retornar una lista con todos los clientes que se encuentran en la tabla Clientes.
    */
    #endregion
    public static class ManejadorSql
    {
        static SqlConnection conexionALaBase;
        static SqlCommand comando;

        static ManejadorSql()
        {
            conexionALaBase = new SqlConnection();
            comando = new SqlCommand();
            comando.Connection = conexionALaBase;
            conexionALaBase.ConnectionString = "Data Source=.; Initial Catalog=Final_Lab2021; Integrated Security=True";
        }

        public static List<Cliente> ObtenerClientes()
        {
            comando.CommandText = "SELECT Dni, Apellido, Nombre FROM dbo.Clientes";

            try
            {
                if (conexionALaBase.State != System.Data.ConnectionState.Open && conexionALaBase.State != System.Data.ConnectionState.Connecting)
                {
                    conexionALaBase.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();
                List<Cliente> lista = new List<Cliente>();
                while (oDr.Read())
                {
                    int dni;
                    int.TryParse(oDr["dni"].ToString(), out dni);
                    string apellido = oDr["apellido"].ToString();
                    string nombre = oDr["nombre"].ToString();

                    Cliente cliente = new Cliente(dni, apellido, nombre);
                    lista.Add(cliente);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer base de datos(Operarios)", ex);
            }
            finally
            {
                conexionALaBase.Close();
            }
        }
    }
}
