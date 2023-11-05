using menuPrincipal.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDepartamento FormDepartamento = new formDepartamento();
            FormDepartamento.MdiParent = this;
            FormDepartamento.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmpleado FormEmpleado = new formEmpleado();
            FormEmpleado.MdiParent = this;
            FormEmpleado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
