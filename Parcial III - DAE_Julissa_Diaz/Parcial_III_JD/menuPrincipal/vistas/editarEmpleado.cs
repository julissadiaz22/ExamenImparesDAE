using menuPrincipal.Modelos;
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
    public partial class editarEmpleado : Form
    {
        public editarEmpleado(int numEmpleado, string apellido, string oficio, int dir, string fecha, double salario, double comision, int depto)
        {
            InitializeComponent();
            numericUpDown1.Text = numEmpleado.ToString();
            textBox1.Text = apellido;
            textBox2.Text = oficio;
            numericUpDown2.Text = dir.ToString();
            dateTimePicker1.Text = fecha;
            numericUpDown3.Text = salario.ToString();
            numericUpDown5.Text= comision.ToString();
            numericUpDown4.Text = depto.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleClase empleClase = new EmpleClase();

            EmpleadoFuncion empleadosFuncion = new EmpleadoFuncion();

            int id = Convert.ToInt32(numericUpDown1.Text);
            string nuevoApelllido = textBox1.Text;
            string nuevoOficio = textBox2.Text;
            int nuevoDIR = Convert.ToInt32(numericUpDown2.Text);
            string nuevaFecha = Convert.ToString(dateTimePicker1.Text);
            double nuevoSalario = Convert.ToDouble(numericUpDown3.Text);
            double nuevaComision = Convert.ToDouble(numericUpDown5.Text);
            int dept_no = Convert.ToInt32(numericUpDown4.Text);

            bool exito = empleadosFuncion.ModificarE(id, nuevoApelllido, nuevoOficio, nuevoDIR, nuevaFecha, nuevoSalario, nuevaComision, dept_no);

            if (exito)
            {
                MessageBox.Show("Los cambios se han guardado con éxito.");
                this.Close(); // Cierra el formulario de edición después de guardar los cambios.

            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar los cambios en la base de datos.");
            }
        }

        private void editarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
