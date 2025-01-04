using Employee_MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Repository
{
    public class DepartmentRepository
    {
        public void Add(DepartmentModel model)
        {
            //Ado.net code

            using (SqlConnection conn = new SqlConnection(""))
            {
                SqlCommand sqlCommand = conn.CreateCommand();
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}