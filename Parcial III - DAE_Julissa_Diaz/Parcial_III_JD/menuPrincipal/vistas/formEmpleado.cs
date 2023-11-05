using menuPrincipal.ConexionBD;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace menuPrincipal.vistas
{
    public partial class formEmpleado : Form

    {
        Transacciones transacciones = new Transacciones();
        DeptoClase deptoClase = new DeptoClase();
        EmpleClase empleClase = new EmpleClase();
        EmpleadoFuncion empleadoFuncion = new EmpleadoFuncion();
        DepartamentosFuncion departamentosFuncion = new DepartamentosFuncion();
 
        public formEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            consultaSalario ConsultaSalario = new consultaSalario();
            ConsultaSalario.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultaPromedio ConsultaPromedio = new consultaPromedio();
            ConsultaPromedio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(numEmpleado.Text) || string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }

            else
            {

                int Dnom = (int)comboDepartamento.SelectedValue;
                int EmN = (int)numEmpleado.Value;
                string apell = txtApellido.Text;
                string oficio = txtOficio.Text;
                string dir = txtDir.Text;
                string fecha = Convert.ToString(date.Text);
                float salario = (float)nuSalario.Value;
                float comision = (float)nuComision.Value;

                empleClase.Dept_no = Dnom;
                empleClase.Emp_no = EmN;
                empleClase.Apellido = apell;
                empleClase.Oficio = oficio;
                empleClase.Dir = dir;
                empleClase.Fecha_alt = fecha;
                empleClase.Salario = salario;
                empleClase.Comision = comision;



                bool resultado = empleadoFuncion.Agregar(empleClase);

                consulta();
                limpiar();


            }

        }

        

        private void consulta()
        {
            DataTable TB = departamentosFuncion.Consulta("select*from empleado");
            dataGridView1.DataSource = TB;
            dataGridView1.Refresh();
        }

         

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void limpiar()
        {
            comboDepartamento.SelectedIndex = 0;
            numEmpleado.Value = 0;
            txtApellido.Clear();
            txtOficio.Clear();
            txtDir.Clear();
            date.Value = DateTime.Now;
            nuSalario.Value = 0;
            nuComision.Value = 0;
            
        }

        private void formEmpleado_Load(object sender, EventArgs e)
        {
            consulta();

            string sql = "select*from departamentos";
            DataTable dt = transacciones.consulta(sql);
            comboDepartamento.DisplayMember = "dnombre";
            comboDepartamento.ValueMember = "dept_no";
            comboDepartamento.DataSource = dt;

            comboBox1.DisplayMember = "dnombre";
            comboBox1.ValueMember = "dept_no";
            comboBox1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
          

            Transacciones transacciones = new Transacciones();
            EmpleClase empleClase = new EmpleClase();

            decimal salarioMedio = transacciones.ObtenerSalarioMedio();
            textBox4.Text = salarioMedio.ToString("C");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                

                int numEmpleado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column1"].Value);
                string  apellido= dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                string oficio = dataGridView1.SelectedRows[0].Cells["Column4"].Value.ToString();
                int dir = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column5"].Value);
                string fecha = dataGridView1.SelectedRows[0].Cells["Column6"].Value.ToString();
                double salario = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["Column7"].Value.ToString());
                double comision = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells["Column8"].Value.ToString());
                int depto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column9"].Value);

                editarEmpleado EditarEmpleado = new editarEmpleado(numEmpleado, apellido, oficio, dir, fecha, salario, comision, depto);

                EditarEmpleado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.");
            }

            consulta();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Transacciones transacciones = new Transacciones();
            empleClase.Dept_no = (int)comboBox1.SelectedValue;
            DataTable dt = transacciones.consulta("select * from empleado where dept_no = '" + empleClase.Dept_no + "'");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
    
}
