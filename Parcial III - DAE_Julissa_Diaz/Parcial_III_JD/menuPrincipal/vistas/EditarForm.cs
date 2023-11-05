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
    public partial class EditarForm : Form
    {
         
        public EditarForm(int id, string nombre, string ubicacion)
        {
            InitializeComponent();
            numericUpDown1.Text = id.ToString();
            textBox1.Text = nombre;
            textBox2.Text = ubicacion;
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeptoClase empleClase  = new DeptoClase();

            DepartamentosFuncion departamentos = new DepartamentosFuncion();

            int id = Convert.ToInt32(numericUpDown1.Text);
            string nuevoNombre = textBox1.Text;
            string nuevaUbicacion = textBox2.Text;

            bool exito = departamentos.ModificarD(id, nuevoNombre, nuevaUbicacion);

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
    }
}
