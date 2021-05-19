using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Controlador;

namespace Modelo
{
    public class M_Factura
    {

        claseConexion con = new claseConexion();

       
            private DataSet ds;

            public DataTable MostrarDatosFactura()
            {
                con.abrir();
                SqlCommand cmd = new SqlCommand("select idproducto,Nombre,Precio from Empleado", con.conectar);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ds = new DataSet();
                ad.Fill(ds, "table");
                con.cerrar(); 

                return ds.Tables["table"];

            }

        public DataTable BuscarProducto(string nombre)
        {
            con.abrir();

            

            SqlCommand cmd = new SqlCommand("Select Precio from Producto where Nombre like '%" + nombre + "%'", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;



        }

        /*   public DataTable BuscarEmpleado(C_MantoEmpleado c_MantoEmpleado)
           {
               conexion.Open();
               SqlDataAdapter cmd = new SqlDataAdapter("Select * from Empleado where Nombre like '%" + c_MantoEmpleado.Nombre + "%'", conexion);
               ds = new DataSet();
               cmd.Fill(ds, "table");

               conexion.Close();

               return ds.Tables[0];

           }
           */

        public int AgregarFactura(C_Factura c_Factura)
            {

                int retorno = 0;

                con.abrir();

                SqlCommand cmd = new SqlCommand(string.Format("insert into Factura (idcliente,idempleado,idsucursal,FechaFacturacion,Total) values ({0},{1},{2},'{3}',{4})",
                    c_Factura.idcliente,c_Factura.idempleado, c_Factura.idsucursal, c_Factura.FechaFacturacion,c_Factura.Total), con.conectar);

                retorno = cmd.ExecuteNonQuery();
                con.cerrar();
                return retorno;
            }
          
            public DataTable CargarcomboboxTablaCliente()
            {
                con.abrir();
                SqlCommand cmd = new SqlCommand(string.Format("select  idcliente, Nombre from Cliente"), con.conectar);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.cerrar();
                return dt;
            }

        public DataTable CargarcomboboxTablaProducto()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select idproducto,Nombre,Precio from Producto"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
        }

        

        public DataTable CargarcomboboxTablaSucursal()
            {
                con.abrir();
                SqlCommand cmd = new SqlCommand(string.Format("select  idsucursal, Nombre from Sucursales"), con.conectar);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                con.cerrar();
                return dt;
            }
            public DataTable CargarcomboboxTablaEmpleado()
            {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idempleado, Nombre from Empleado"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
            }

     /*   public int EliminarEmpleado(C_MantoEmpleado c_MantoEmpleado)
            {
                int retorno = 0;
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("Delete from Empleado where idempleado = {0}", c_MantoEmpleado.idempleado), conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();

                return retorno;


            }

            public int ActualizarEmpleado(C_MantoEmpleado pC_MantoEmpleado)
            {
                int filas = 0;

                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("update Empleado set Nombre = '{0}', Apellido = '{1}', Cargo = '{2}', FechaNacimiento = '{3}', FechaContratacion = '{4}', Direccion = '{5}', idsucursal = {6}, Telefono = '{7}', Correo = '{8}', DUI = '{9}', Usuario = '{10}', Contrasena = '{11}', idrol = {12} where idempleado = {13}",
                pC_MantoEmpleado.Nombre, pC_MantoEmpleado.Apellido, pC_MantoEmpleado.Cargo, pC_MantoEmpleado.FechaNacimiento, pC_MantoEmpleado.FechaContratacion, pC_MantoEmpleado.direccion, pC_MantoEmpleado.idsucursal, pC_MantoEmpleado.Telefono, pC_MantoEmpleado.Correo, pC_MantoEmpleado.DUI, pC_MantoEmpleado.Usuario, pC_MantoEmpleado.Contrasena, pC_MantoEmpleado.idrol, pC_MantoEmpleado.idempleado), conexion);

                filas = cmd.ExecuteNonQuery();
                conexion.Close();


                return filas;


            }

    */    
    }
}
