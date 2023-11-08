using System.Data.SqlClient;

namespace ToDoList5.Data
{
    public class Connection
    {
        public static SqlConnection? connection;
        static string connectionString = "Server=.\\SQLEXPRESS;Database=MyToDoList;Trusted_Connection=True";
        public static void Connect()
        {
            try
            {
                connection = new(connectionString);
                connection.Open();
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("");
            }
        }


    }
}