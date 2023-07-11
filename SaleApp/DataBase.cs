using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SaleApp
{
    internal class DataBase
    {
        public SqlConnection sqlConnection = new SqlConnection(
            @"Data Source =LAPTOP-05NUUR6L; 
            Initial Catalog=SaleDB; 
            Integrated Security=True; 
            User ID =LAPTOP-05NUUR6L/hyppe");

        public void OpenCon()
        {

           sqlConnection.Open();

        }

        public void CloseCon()
        {
           sqlConnection.Close();
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
