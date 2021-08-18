using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ProductoDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public ProductoDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            //No hace falta ponerlo como Text, por default ya lo es
            //this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }

        public List<Producto> GetProductos()
        {
            comando.CommandText = "SELECT id, descripcion FROM Productos";

            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();

            List<Producto> lista = new List<Producto>();
            while (oDr.Read())

            {
                int id;
                int.TryParse(oDr["id"].ToString(), out id);
                string descripcion = oDr["descripcion"].ToString();
                Producto prod = new Producto(id, descripcion);
                lista.Add(prod);
            }
            return lista;
        }
    }
}
