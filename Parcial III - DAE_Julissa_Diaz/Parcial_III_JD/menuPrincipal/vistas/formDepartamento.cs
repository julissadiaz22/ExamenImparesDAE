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
    public partial class formDepartamento : Form
    {

        Transacciones transacciones = new Transacciones();
        DeptoClase deptoClase = new DeptoClase();
        DepartamentosFuncion departamentosFuncion = new DepartamentosFuncion();

        public formDepartamento()
        {

            InitializeComponent();

        }

        private bool DuplicadosDepartamento(int Depto)
        {
            string consultaSQL = "SELECT dept_no FROM departamentos";
            DataTable dt = departamentosFuncion.consulta(consultaSQL);

            foreach (DataRow row in dt.Rows)
            {
                int existeDepto = (int)(row["dept_no"]);
                if (existeDepto == Depto)
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)


        {
            int Depto = (int)numId.Value;
            if (DuplicadosDepartamento(Depto))
            {
                MessageBox.Show("El departamento ya existe");
                limpiar();
            }

            else if (string.IsNullOrEmpty(numId.Text) || string.IsNullOrEmpty(txtDepto.Text) || string.IsNullOrEmpty(txtUbicacion.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            
           
            else
            {
                int idDepto = Convert.ToInt32(numId.Value);
                string nDepto = txtDepto.Text;
                string ubDepto = txtUbicacion.Text;


                deptoClase.Dept_no = idDepto;
                deptoClase.Dnombre = nDepto;
                deptoClase.Loc = ubDepto;




                bool resultado = departamentosFuncion.Agregar(deptoClase);
                consulta();
                limpiar();

            
        }


        }

        private void formDepartamento_Load(object sender, EventArgs e)
        {
            consulta();

        }

        private void consulta()

        {
            
            DataTable TB = departamentosFuncion.Consulta("select*from departamentos");
            dataGridView1.DataSource = TB;
            dataGridView1.Refresh();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtén los valores de la fila seleccionada en el DataGridView
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Column1"].Value);
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                string ubicacion = dataGridView1.Rows[e.RowIndex].Cells["Column3"].Value.ToString();

                // Llena los TextBox con los valores obtenidos
                numId.Value = id;
                txtDepto.Text = nombre;
                txtUbicacion.Text = ubicacion;
            }


            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                numId.Value = Convert.ToInt32(row.Cells["Column1"].Value);
                txtDepto.Text = row.Cells["Column2"].Value.ToString();
                txtUbicacion.Text = row.Cells["Column3"].Value.ToString();
            }
        


    }
        private void limpiar()
        {
            numId.Value = 0;
            txtDepto.Clear();
            txtUbicacion.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // Obtiene la fila seleccionada
                //int id = Convert.ToInt32(selectedRow.Cells["Column1"].Value); // Obtiene el valor de la columna "Column1"

                DepartamentosFuncion departamentosFuncion = new DepartamentosFuncion();

                deptoClase.Dept_no = Convert.ToInt32(selectedRow.Cells["Column1"].Value);
                // Llama a la función Elimnar pasando el ID
                if (departamentosFuncion.Elimnar(deptoClase.Dept_no)) {

                    MessageBox.Show("Registro Eliminado");
                    consulta();
                }

                
                
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                 
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column1"].Value);
                string nombre = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                string ubicacion = dataGridView1.SelectedRows[0].Cells["Column3"].Value.ToString();

                 
                EditarForm editarForm = new EditarForm(id, nombre, ubicacion);
 
                editarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar.");
            }

            consulta();
        }
    }
} 
