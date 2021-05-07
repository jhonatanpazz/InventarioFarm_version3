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
    public class M_Sucursal
    {

        claseConexion con = new claseConexion();

        private DataSet ds;


        public DataTable MostrarSucursales()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from Sucursales", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            con.cerrar();

            return ds.Tables["table"];

        }

        public DataTable BuscarSucursal(C_Sucursal c_Sucursal)
        {
            con.abrir();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Sucursales where Nombre like '%" + c_Sucursal.Nombre + "%'", con.conectar);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            con.cerrar();

            return ds.Tables[0];

        }

        public int AgregarSucursal(C_Sucursal c_Sucursal)
        {

            int retorno = 0;

            con.abrir();

            SqlCommand cmd = new SqlCommand(string.Format("Insert into Sucursales (Nombre,Direccion,Gerente,CantidadEmpleado) values ('{0}','{1}','{2}',{3})",
                c_Sucursal.Nombre, c_Sucursal.Direccion, c_Sucursal.Gerente, c_Sucursal.Cantidad), con.conectar);

            retorno = cmd.ExecuteNonQuery();
            con.cerrar();
            return retorno;
        }

       
        public int EliminarSucursal(C_Sucursal c_Sucursal)
        {
            int retorno = 0;
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Sucursales where idsucursal = {0}", c_Sucursal.idsucursal), con.conectar);
            retorno = cmd.ExecuteNonQuery();
            con.cerrar();

            return retorno;


        }

        public int ActualizarSucursal(C_Sucursal c_Sucursal)
        {
            int filas = 0;

            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("update Sucursales set Nombre = '{0}', Direccion = '{1}', Gerente = '{2}', CantidadEmpleado = {3} where idsucursal = {4}", 
                c_Sucursal.Nombre, c_Sucursal.Direccion, c_Sucursal.Gerente, c_Sucursal.Cantidad, c_Sucursal.idsucursal), con.conectar);

            filas = cmd.ExecuteNonQuery();
            con.cerrar();


            return filas;


        }
    }
}
