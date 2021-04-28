using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class C_MantoEmpleado
    {
        public String idempleado { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Cargo { get; set; }
        public String FechaNacimiento { get; set; }
        public String FechaContratacion { get; set; }
        public String direccion { get; set; }
        public String idsucursal { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }
        public String DUI { get; set; }
        public String Usuario { get; set; }
        public String Contrasena { get; set; }
        public String idrol { get; set; }

        public C_MantoEmpleado()
        {

        }

        public C_MantoEmpleado(String pidempleado, String pNombre, String pApellido, String pCargo, String pFechaNacimiento, String pFechaContratacion, String pDireccion, String pidsucursal, String pTelefono, String pCorreo, String pDui,String pUsuario, String pContrasena, String pidrol)
        {
            this.idempleado = pidempleado;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Cargo = pCargo;
            this.FechaNacimiento = pFechaNacimiento;
            this.FechaContratacion = pFechaNacimiento;
            this.direccion = pDireccion;
            this.idsucursal = pidsucursal;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.DUI = pDui;
            this.Usuario = pUsuario;
            this.Contrasena = pContrasena;
            this.idrol = pidrol;
           
;
        }

    }
}
