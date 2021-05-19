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
    public class M_Dfactura
    {

        claseConexion con = new claseConexion();

        private DataSet ds;


        public DataTable MostrarDetalle()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from DetalleFactura", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            con.cerrar();

            return ds.Tables["table"];

        }

        public DataTable CargarcomboboxTablaFactura()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idfactura from Factura"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
        }

        public DataTable CargarcomboboxTablaProducto()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idproducto from Producto"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
        }
        public DataTable BuscarDFactura(C_Inventario c_Inventario)
        {
            con.abrir();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Inventario where NombreProducto like '%" + c_Inventario.NombreProducto + "%'", con.conectar);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            con.cerrar();

            return ds.Tables[0];

        }

        public int AgregarInventario(C_DetalleFactura dfactura)
        {

            int retorno = 0;

            con.abrir();

            SqlCommand cmd = new SqlCommand(string.Format("Insert into DetalleFactura(idfactura,idproducto,cantidad,fecha) values ({0},{1},{2},'{3}')",
                dfactura.idfactura, dfactura.idproducto, dfactura.cantidad, dfactura.fecha), con.conectar);

            retorno = cmd.ExecuteNonQuery();
            con.cerrar();
            return retorno;
        }


        public int EliminarDFactura(C_DetalleFactura dfactura)
        {
            int retorno = 0;
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from DetalleFactura where iddetalle = {0}", dfactura.iddetalle), con.conectar);
            retorno = cmd.ExecuteNonQuery();
            con.cerrar();

            return retorno;


        }

        public int ActualizarI(C_Inventario c_Inventario)
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
