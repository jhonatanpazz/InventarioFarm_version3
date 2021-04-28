﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Controlador;


namespace Modelo
{
    public class M_Empleado
    {


        claseConexion con = new claseConexion();

        public DataTable M_empleado(C_Empleado obje)
        {

            SqlCommand cmd = new SqlCommand("sp_Login", con.conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.Usuario);
            cmd.Parameters.AddWithValue("@contrasena", obje.Contrasena);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
            

        }

       
    }
}
