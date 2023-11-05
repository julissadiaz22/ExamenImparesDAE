using menuPrincipal.Modelos;
using menuPrincipal.vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuPrincipal.ModelosFunciones
{
    internal class DepartamentosFuncion : ConexionBD.Transacciones, Interfaces.InterfaceCRUD
    {
        EmpleadoFuncion empleadoFuncion = new EmpleadoFuncion();
        
        public bool Agregar(object Objeto)
        {

            DeptoClase deptoClase = new DeptoClase();
            deptoClase = (DeptoClase)Objeto;
            string sql = "insert into DEPARTAMENTOS(dept_no, dnombre, loc) values('"+deptoClase.Dept_no+"','"+deptoClase.Dnombre+"','"+deptoClase.Loc+"')";
          
            this.ejecutarComando(sql);
            

            return true;


        }

        public DataTable Consulta(string tabla)
        {
            
            return this.consulta(tabla);
        }

        public bool Elimnar(object Objeto)
        {
            

            try
            {
                if (Objeto is int)
                {
                    DeptoClase deptoClase = new DeptoClase();
                    int id = (int)Objeto;
                    string sql = "delete from departamentos where dept_no = '" + id+ "'";
                    this.ejecutarComando(sql);
                   
                    return true;
                }
                else
                {
                    
                    Console.WriteLine("El objeto no es un entero válido para eliminar.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar registro: " + ex.Message);
                return false;
            }
        }

        public bool Modificar(object Object)
        {
            throw new NotImplementedException();
        }

        public bool ModificarD(int dept_no, string nuevoNombre, string nuevaLoc)
        {
            DeptoClase deptoClase = new DeptoClase();
            string sql = "UPDATE DEPARTAMENTOS SET dnombre = '" + nuevoNombre + "', loc = '" + nuevaLoc + "' WHERE dept_no = '" + dept_no + "'";

            return this.ejecutarComando(sql);

        }

       
         
}
}
