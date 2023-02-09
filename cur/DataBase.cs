using System.Data.SqlClient;

namespace cur
{
    class DataBase
    {
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-LP43O0S;Initial Catalog=Bank_Task1;Integrated Security=True");

        public void openConnection()
        {
            if(sql.State == System.Data.ConnectionState.Closed)
            {
                sql.Open();
            }
        }
        public void closeConnection()
        {
            if (sql.State == System.Data.ConnectionState.Open)
            {
                sql.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sql;
        }
    }
}
