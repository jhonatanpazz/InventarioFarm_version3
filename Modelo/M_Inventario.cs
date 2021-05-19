using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class M_Inventario
    {

        claseConexion con = new claseConexion();

        private DataSet ds;


        public DataTable MostrarInventario()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from Inventario", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            con.cerrar();

            return ds.Tables["table"];

        }

        public DataTable CargarcomboboxTablaInventarioP()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idproducto from Producto"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
        }

        public DataTable BuscarInventario(C_Inventario c_Inventario)
        {
            con.abrir();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Inventario where NombreProducto like '%" + c_Inventario.NombreProducto + "%'", con.conectar);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            con.cerrar();

            return ds.Tables[0];

        }

        public int AgregarInventario(C_Inventario c_Inventario)
        {

            int retorno = 0;

            con.abrir();

            SqlCommand cmd = new SqlCommand(string.Format("Insert into Inventario (idproducto,Cantidad,NombreProducto,FechaInventario) values ({0},{1},'{2}','{3}')",
                c_Inventario.idproducto,c_Inventario.Cantidad, c_Inventario.NombreProducto, c_Inventario.FechaInventario), con.conectar);

            retorno = cmd.ExecuteNonQuery();
            con.cerrar();
            return retorno;
        }


        public int EliminarInventario(C_Inventario c_Inventario)
        {
            int retorno = 0;
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Inventario where idinventario = {0}", c_Inventario.idinventario), con.conectar);
            retorno = cmd.ExecuteNonQuery();
            con.cerrar();

            return retorno;


        }

        public int ActualizarInventario(C_Inventario c_Inventario)
        {
            int filas = 0;

            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("update Inventario set idproducto = {0}, Cantidad = {1}, NombreProducto = '{2}', FechaInventario = '{3}' where idinventario = {4}",
               c_Inventario.idproducto, c_Inventario.Cantidad, c_Inventario.NombreProducto, c_Inventario.FechaInventario), con.conectar);

            filas = cmd.ExecuteNonQuery();
            con.cerrar();


            return filas;


        }
    }
}
