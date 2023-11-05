using menuPrincipal.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace menuPrincipal.ModelosFunciones
{
    internal class EmpleadoFuncion : ConexionBD.Transacciones, Interfaces.InterfaceCRUD
    {
        public bool Agregar(object Objeto)
        {
                EmpleClase empleClase = new EmpleClase();
                empleClase = (EmpleClase)Objeto;
                string sql = "insert into empleado(emp_no, apellido, oficio, dir, fecha_alt, salario, comision, dept_no) values ('" + empleClase.Emp_no+ "','" + empleClase.Apellido + "','" + empleClase.Oficio + "','" + empleClase.Dir + "','" + empleClase.Fecha_alt + "','" + empleClase.Salario + "','" + empleClase.Comision + "','" + empleClase.Dept_no + "')";
              
                this.ejecutarComando(sql);

                return true;
        }

        public DataTable Consulta(string tabla)
        {
            
            return this.consulta(tabla);
        }

        public bool Elimnar(object Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(object Objeto)
        {
            throw new NotImplementedException();
        }

        public bool ModificarE(int empl_no, string nuevoApellido, string nuevoOficio,int nuevoDIR, string nuevaFecha, double nuevoSalario, double nuevaComision, int dept_no)
        {
            EmpleClase empleClase = new EmpleClase();
            string sql = "UPDATE empleado SET dept_no = '"+dept_no+ "' , apellido = '" + nuevoApellido + "', oficio='"+nuevoOficio+"', dir= '"+nuevoDIR+"', fecha_alt= '"+nuevaFecha+"', salario='"+nuevoSalario+"', comision='"+nuevaComision+"' WHERE emp_no = '" + empl_no + "'";

            return this.ejecutarComando(sql);

        }
    }
}
