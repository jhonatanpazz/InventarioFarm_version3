using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventarioFarm_version3
{
    class consultasSqlClientes

    {
        SqlConnection conexion = new SqlConnection("SERVER=ADMINHO-N9KI8HV;DATABASE=InvFarmacia;Integrated security=true");

        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Cliente", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            conexion.Close();

            return ds.Tables["table"];
       
        }
        public DataTable BuscarCliente(string nombre)
        {
            conexion.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Cliente where Nombre like '%" + nombre + "%'", conexion);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            conexion.Close();

            return ds.Tables[0];

        }
        public bool Insertar(string Nombre, string Apellido, string Direccion, string Telefono, string Email)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Cliente values ('{0}','{1}','{2}','{3}','{4}')", new string[] { Nombre, Apellido, Direccion, Telefono, Email }),conexion);
            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            if (filas > 0)
            {
                return true;
            }
             else
            {
                return false;
            }
            
           
        }
        public bool Eliminar(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Cliente where idcliente = {0}", id), conexion);
            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Actualizar(string id, string Nombre, string Apellido, string Direccion, string Telefono, string Email)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Cliente set Nombre = '{0}', Apellido = '{1}', Direccion = '{2}', Telefono = '{3}', Email = '{4}' where idcliente = {5}" , new string[] { Nombre, Apellido,Direccion,Telefono,Email, id}), conexion);
            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            if (filas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

      
    }
}
