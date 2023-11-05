using menuPrincipal.ConexionBD;
using menuPrincipal.ModelosFunciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuPrincipal.vistas
{
    public partial class consultaSalario : Form
    {
        Transacciones transacciones = new Transacciones();
        public consultaSalario()
        {
            InitializeComponent();
        }

        private void consultaSalario_Load(object sender, EventArgs e)
        {

            Transacciones transacciones = new Transacciones();

            decimal salarioMaximo = transacciones.ObtenerSalarioMaximo();
            decimal salarioMinimo = transacciones.ObtenerSalarioMinimo();

            // Limpia la DataGridView si ya contiene datos
            dataGridView1.Rows.Clear();

            // Agrega el salario máximo en la fila 0
            dataGridView1.Rows.Add("Salario Mayor", salarioMaximo);

            // Agrega el salario mínimo en la fila 1
            dataGridView1.Rows.Add("Salario Menor", salarioMinimo);


        }
    }
}
