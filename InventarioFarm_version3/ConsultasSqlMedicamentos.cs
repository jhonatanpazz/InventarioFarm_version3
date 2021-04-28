using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventarioFarm_version3
{
    class ConsultasSqlMedicamentos
    {

        SqlConnection conexion = new SqlConnection("SERVER=ADMINHO-N9KI8HV;DATABASE=InvFarmacia;Integrated security=true");

        private DataSet ds;

        public DataTable MostrarDatosMedicamento()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Producto", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            conexion.Close();

            return ds.Tables["table"];

        }

        public DataTable BuscarMedicamento(string nombre)
        {
            conexion.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Producto where Nombre like '%" + nombre + "%'", conexion);
            ds = new DataSet();
            cmd.Fill(ds, "table");
            
            conexion.Close();
          
            return ds.Tables[0];

        }
        public DataTable CargarcomboboxTablaProducto_prov()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select  idproveedor,Empresa from Proveedores"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable CargarcomboboxTablaProducto_Categoria()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select  idcategoria,NombreCategoria from CategoriaMedicamento"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conexion.Close();
            return dt;
        }

        public DataTable CargarcomboboxTablaProducto_marca()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select  idmarca, Nombre from Marcas"), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            conexion.Close();
            return dt;
        }


        public bool InsertarMedicamento(string Nombre, string idcategoria, string Precio, string Descripcion, string idmarcas, string idproveedor)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Producto values ('{0}',{1},{2},'{3}',{4},{5})", new string[] { Nombre, idcategoria, Precio, Descripcion, idmarcas, idproveedor }), conexion);
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

        public bool EliminarMedicamento(string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Producto where idproducto = {0}", id), conexion);
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

        public bool ActualizarMedicamento(String id, string Nombre, string idcategoria, string Precio, string Descripcion, string idmarcas, string idproveedor)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Producto set Nombre = '{0}', idcategoria = {1}, Precio = {2}, Descripcion = '{3}', idmarcas = {4}, idproveedor = {5} where idproducto = {6}", new string[] { Nombre,  idcategoria,  Precio,  Descripcion, idmarcas,  idproveedor, id }), conexion);
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