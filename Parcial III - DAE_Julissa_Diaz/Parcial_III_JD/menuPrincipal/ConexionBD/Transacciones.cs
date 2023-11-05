using menuPrincipal.ModelosFunciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuPrincipal.ConexionBD
{
    internal class Transacciones
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        String cadena = "Data source= JULISSA\\SQLEXPRESS2;Initial Catalog= LAB3_JD; integrated security= true";


        public Transacciones()
        {
            con.ConnectionString = cadena;
        }
        //INSERTAR, ELIMINAR, ACTUALIZAR
        public bool ejecutarComando(string sql)
        {

            cmd.CommandText = sql;
            cmd.Connection = this.con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return true;
        }



    



        

        public DataTable consulta(string sentenciaSQL)
        {
            DataTable miTabla = new DataTable();
            adapter = new SqlDataAdapter(sentenciaSQL, this.con);
            adapter.Fill(miTabla);

            return miTabla;

        }




        public decimal ObtenerSalarioMedio()
        {
           

            string sql = "SELECT AVG(salario) FROM empleado";

           
            decimal salarioMedio = 0;

           
            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();

           
            var result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                
                salarioMedio = Convert.ToDecimal(result);
            }

          
            con.Close();

            return salarioMedio;

        }

        public decimal ObtenerSalarioMaximo()
        {
            string sql = "SELECT MAX(salario) FROM empleado";

            decimal salarioMaximo = 0;

            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();

            var result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                salarioMaximo = Convert.ToDecimal(result);
            }

            con.Close();

            return salarioMaximo;
        }

        public decimal ObtenerSalarioMinimo()
        {
            string sql = "SELECT MIN(salario) FROM empleado";

            decimal salarioMinimo = 0;

            cmd.CommandText = sql;
            cmd.Connection = con;
            con.Open();

            var result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                salarioMinimo = Convert.ToDecimal(result);
            }

            con.Close();

            return salarioMinimo;
        }

        public DataTable ObtenerCantidadEmple()
        {
            string sql = "SELECT dept_no, COUNT(*) AS CantidadEmpleados, AVG(salario) AS SalarioPromedio FROM empleado GROUP BY dept_no";

            DataTable resultado = new DataTable();
            cmd.CommandText = sql;
            cmd.Connection = con;

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                resultado.Load(reader);
            }
            catch 
            {
                 
            }
            finally
            {
                con.Close();
            }

            return resultado;
        }



    }
}
