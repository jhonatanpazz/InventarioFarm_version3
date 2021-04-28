using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Modelo
{
    public class claseConexion
    {

        string cadena = "SERVER=ADMINHO-N9KI8HV;DATABASE=InvFarmacia;Integrated security=true";

        public SqlConnection conectar = new SqlConnection(); 
        

            public void abrir()
        {
            try
            {
                conectar.ConnectionString = cadena;
                conectar.Open();
            }
            catch (Exception ex)
            {
               
            }


        }
        public void cerrar()
        {
            conectar.Close();
        }


    }
}
