using Accessibility;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Lab2DavidAlvarado.Controller
{
    class DataController
    {
        private SqlConnection conexion = new SqlConnection("Data Source=tcp:163.178.107.10;Initial Catalog=IF4101_LAB2_B60315;User ID=laboratorios;Password=Saucr.118");
        public bool InsertIntoDB(string name, string lastName, string age, string id, string email, string pass)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand("SP_ADD_USER", conexion);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@UserName", name));
            command.Parameters.Add(new SqlParameter("@LastName", lastName));
            command.Parameters.Add(new SqlParameter("@Age", age));
            command.Parameters.Add(new SqlParameter("@Cedula", id));
            command.Parameters.Add(new SqlParameter("@Email", email));
            command.Parameters.Add(new SqlParameter("@pPassword", pass));
            command.Parameters.Add(new SqlParameter("@responseMessage", name));

            /*command.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = lastName.Trim();
            command.Parameters.AddWithValue("@Age", SqlDbType.TinyInt).Value = age.Trim();
            command.Parameters.AddWithValue("@Cedula", SqlDbType.VarChar).Value = id.Trim();
            command.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email.Trim();
            command.Parameters.AddWithValue("@pPassword", SqlDbType.NVarChar).Value = pass.Trim();
            command.Parameters.AddWithValue("@responseMessage", SqlDbType.NVarChar).Value = null;*/
            try
            {
                command.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException e)
            {
                conexion.Close();
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        
    }
}
