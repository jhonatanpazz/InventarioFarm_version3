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
    public class M_Ingresos
    {

        claseConexion con = new claseConexion();

        private DataSet ds;


        public DataTable MostrarDatosIngreso()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from Ingreso", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            con.cerrar();

            return ds.Tables["table"];

        }

        public DataTable BuscarIngreso(C_Ingresos ingresos)
        {
            con.abrir();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Ingreso where idIngreso like '%" + ingresos.idIngreso + "%'", con.conectar);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            con.cerrar();

            return ds.Tables[0];

        }

        public int AgregarIngreso(C_Ingresos ingresos)
        {

            int retorno = 0;

            con.abrir();

            SqlCommand cmd = new SqlCommand(string.Format("Insert into Ingreso (idproducto,idbodega,FechaRegistro,NoFactura,Descripcion,idmarca,CantidadIngreso,CostoIngreso) values ({0},{1},'{2}','{3}','{4}',{5},{6},{7})",
                ingresos.idproducto, ingresos.idbodega,ingresos.FechaRegistro, ingresos.NoFactura, ingresos.Descripcion, ingresos.idmarca, ingresos.CantidadIngreso,ingresos.CostoIngreso), con.conectar);

            retorno = cmd.ExecuteNonQuery();
            con.cerrar();
            return retorno;
        }

        public DataTable CargarcomboboxTablaproducto()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idproducto from Producto"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.abrir();
            return dt;
        }
        public DataTable CargarcomboboxTablabodega()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idbodega from Bodega"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
        }

        public DataTable CargarcomboboxTablamarca()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("select  idmarca  from Marcas"), con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.cerrar();
            return dt;
        }

        public int EliminarEmpleado(C_MantoEmpleado c_MantoEmpleado)
        {
            int retorno = 0;
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Empleado where idempleado = {0}", c_MantoEmpleado.idempleado), con.conectar);
            retorno = cmd.ExecuteNonQuery();
            con.cerrar();

            return retorno;


        }

        public int ActualizarEmpleado(C_MantoEmpleado pC_MantoEmpleado)
        {
            int filas = 0;

            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("update Empleado set Nombre = '{0}', Apellido = '{1}', Cargo = '{2}', FechaNacimiento = '{3}', FechaContratacion = '{4}', Direccion = '{5}', idsucursal = {6}, Telefono = '{7}', Correo = '{8}', DUI = '{9}', Usuario = '{10}', Contrasena = '{11}', idrol = {12} where idempleado = {13}",
            pC_MantoEmpleado.Nombre, pC_MantoEmpleado.Apellido, pC_MantoEmpleado.Cargo, pC_MantoEmpleado.FechaNacimiento, pC_MantoEmpleado.FechaContratacion, pC_MantoEmpleado.direccion, pC_MantoEmpleado.idsucursal, pC_MantoEmpleado.Telefono, pC_MantoEmpleado.Correo, pC_MantoEmpleado.DUI, pC_MantoEmpleado.Usuario, pC_MantoEmpleado.Contrasena, pC_MantoEmpleado.idrol, pC_MantoEmpleado.idempleado), con.conectar);

            filas = cmd.ExecuteNonQuery();
            con.cerrar();


            return filas;


        }

    }
}
