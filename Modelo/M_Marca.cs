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
    public class M_Marca
    {

        claseConexion con = new claseConexion();

        private DataSet ds;


        public DataTable MostrarMarcas()
        {
            con.abrir();
            SqlCommand cmd = new SqlCommand("select * from Marcas", con.conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "table");
            con.cerrar();

            return ds.Tables["table"];

        }

        public DataTable BuscarMarca(C_Marca c_Marca)
        {
            con.abrir();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * from Marcas where Nombre like '%" + c_Marca.Nombre + "%'", con.conectar);
            ds = new DataSet();
            cmd.Fill(ds, "table");

            con.cerrar();

            return ds.Tables[0];

        }

        public int AgregarMarca(C_Marca c_Marca)
        {

            int retorno = 0;

            con.abrir();

            SqlCommand cmd = new SqlCommand(string.Format("Insert into Marcas (Nombre) values ('{0}')",c_Marca.Nombre), con.conectar);

            retorno = cmd.ExecuteNonQuery();
            con.cerrar();
            return retorno;
        }


        public int EliminarMarca(C_Marca c_Marca)
        {
            int retorno = 0;
            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("Delete from Marcas where idmarca = {0}", c_Marca.idmarca), con.conectar);
            retorno = cmd.ExecuteNonQuery();
            con.cerrar();

            return retorno;


        }

        public int ActualizarMarca(C_Marca c_Marca)
        {
            int filas = 0;

            con.abrir();
            SqlCommand cmd = new SqlCommand(string.Format("update Marcas set Nombre = '{0}' where idmarca = {1}",
                c_Marca.Nombre, c_Marca.idmarca), con.conectar);

            filas = cmd.ExecuteNonQuery();
            con.cerrar();


            return filas;


        }
    }
}
