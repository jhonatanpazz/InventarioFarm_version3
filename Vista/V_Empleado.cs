using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using Controlador;

namespace Vista
{
    public class V_Empleado
    {
        M_Empleado obj = new M_Empleado();

        public DataTable V_empleado(C_Empleado obje)
        {

            return obj.M_empleado(obje);
        }
    }
}
