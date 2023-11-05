using menuPrincipal.ConexionBD;
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
    public partial class consultaPromedio : Form
    {
        public consultaPromedio()
        {
            InitializeComponent();
        }

        private void consultaPromedio_Load(object sender, EventArgs e)
        {
            
                Transacciones transacciones = new Transacciones();
                DataTable empleadosYSalarioPorDepartamento = transacciones.ObtenerCantidadEmple();

                if (empleadosYSalarioPorDepartamento.Rows.Count > 0)
                {
                    dataGridView1.DataSource = empleadosYSalarioPorDepartamento;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos.");
                }
            

        }
    }
}
