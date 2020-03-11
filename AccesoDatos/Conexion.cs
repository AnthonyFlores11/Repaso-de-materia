using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    class Conexion
    {

        private string connectionString = "Data Source=DESKTOP-SNQBSJ2;Initial Catalog=Progra3;User ID=UserPR3;Password=12345";


        public void ConexionSQLNoQuery(string sql) // No retorna nada
        {
            SqlConnection cnn;
            SqlCommand cmd;


            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                //SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();
                Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close();
            }
        }

        public SqlDataReader ConexionSQLQuery(string sql) // Retorna algun elemento
        {
            SqlConnection cnn;
            SqlCommand cmd;


            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                //cmd.ExecuteNonQuery();
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();
                if (resultado.HasRows)
                {
                    cnn.Close();
                    return resultado;
                }
                else
                {
                    Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {

                cnn.Close();

            }
            return null;
        }

        public void ConexionADO(string sql)
        {
            try
            {
                string querystring = "Select * from Items";
                SqlDataAdapter adapter = new SqlDataAdapter(querystring, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }

        }
    }
}
