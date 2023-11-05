using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuPrincipal.Modelos
{
    internal class EmpleClase
    {
        private int emp_no;
        private string apellido;
        private string oficio;
        private string dir;
        private string fecha_alt;
        private float salario;
        private float comision;
        private int dept_no;

      

        public EmpleClase()
        {
        }

        public EmpleClase(int emp_no, string apellido, string oficio, string dir, string fecha_alt, float salario, float comision, int dept_no)
        {
            this.emp_no = emp_no;
            this.apellido = apellido;
            this.oficio = oficio;
            this.dir = dir;
            this.fecha_alt = fecha_alt;
            this.salario = salario;
            this.comision = comision;
            this.dept_no = dept_no;
        }


        public int Emp_no
        {
            get { return emp_no; }
            set { emp_no = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Oficio
        {
            get { return oficio; }
            set { oficio = value; }
        }

        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }

        public string Fecha_alt
        {
            get { return fecha_alt; }
            set { fecha_alt = value; }
        }

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }


        public float Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public int Dept_no
        {
            get { return dept_no; }
            set { dept_no = value; }
        }
    }


}
