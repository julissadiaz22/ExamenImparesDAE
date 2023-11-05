using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuPrincipal.Modelos
{
    internal class DeptoClase
    {
        private int dept_no;
        private string dnombre;
        private string loc;

        public DeptoClase()
        {
        }

        public DeptoClase(int dept_no, string dnombre, string loc)
        {
            this.dept_no = dept_no;
            this.dnombre = dnombre;
            this.loc = loc;
        }


        public int Dept_no
        {
            get { return dept_no; }
            set { dept_no = value; }

        }


        public string Dnombre
        {
            get { return dnombre; }
            set { dnombre = value; }

        }

        public string Loc
        {
            get { return loc; }
            set { loc = value; }
        }



    }




}
