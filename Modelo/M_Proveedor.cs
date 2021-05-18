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
    public class M_Proveedor
    {

        claseConexion con = new claseConexion();

        private DataSet ds;


        public DataTable MostrarProveedores()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from Proveedores", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            con.cerrar();

            return ds.Tables["table"];

        }

        public DataTable BuscarProveedores(C_Proveedor c_Proveedor)
        {
            con.abrir();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Proveedores where NombreContacto like '%" + c_Proveedor.NombreContacto + "%'", con.conectar);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            con.cerrar();

            return ds.Tables[0];

        }

        public int AgregarProveedor(C_Proveedor c_Proveedor)
        {

            int retorno = 0;

            con.abrir();

            SqlCommand cmd = new SqlCommand(string.Format("Insert into Proveedores (Empresa,NombreContacto,Direccion,Ciudad,Region,CodPostal,Pais,Telefono,Email) values ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}')",
                c_Proveedor.Empresa, c_Proveedor.NombreContacto, c_Proveedor.Direccion, c_Proveedor.Ciudad, c_Proveedor.Region, c_Proveedor.CodPostal, c_Proveedor.Pais, c_Proveedor.Telefono, c_Proveedor.Email), con.conectar);

            retorno = cmd.ExecuteNonQuery();
            con.cerrar();
            return retorno;
        }


        public int EliminarProveedor(C_Proveedor c_Proveedor)
        {
            int retorno = 0;
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Proveedores where idproveedor = {0}", c_Proveedor.idproveedor), con.conectar);
            retorno = cmd.ExecuteNonQuery();
            con.cerrar();

            return retorno;


        }

        public int ActualizarProveedor(C_Proveedor c_Proveedor)
        {
            int filas = 0;

            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("update Proveedores set Empresa = '{0}', NombreContacto = '{1}', Direccion = '{2}', Ciudad = '{3}', Region = '{4}', CodPostal = '{5}', Pais = '{6}', Telefono = '{7}', Email = '{8}' where idproveedor = {9}",
            c_Proveedor.Empresa, c_Proveedor.NombreContacto, c_Proveedor.Direccion, c_Proveedor.Ciudad, c_Proveedor.Region, c_Proveedor.CodPostal, c_Proveedor.Pais, c_Proveedor.Telefono, c_Proveedor.Email, c_Proveedor.idproveedor), con.conectar);

            filas = cmd.ExecuteNonQuery();
            con.cerrar();


            return filas;


        }
    }
}

