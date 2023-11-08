using System;
using System.Data;
using System.Data.SqlClient;
using ToDoList5.Model;

namespace ToDoList5.Data
{
    public class Repository : Connection
    {
        public static void SaveToDatabase(TodolistModel tmodel)
        {
            string insertQuery = "INSERT INTO ToDoList ( Activity, Description, CreationDate) VALUES ( @Activity, @Description, @CreationDate); SELECT SCOPE_IDENTITY();";
            using (SqlCommand insertCmd = new(insertQuery, connection))
            {
                insertCmd.Parameters.AddWithValue("@Activity", tmodel.Activity);
                insertCmd.Parameters.AddWithValue("@Description", tmodel.Description);
                insertCmd.Parameters.AddWithValue("@CreationDate", tmodel.CreationDate);
                insertCmd.ExecuteScalar();
            }
        }

        public static DataSet ViewRecords()
        {
            // Retrieve data from the ToDoList table
            string selectQuery = "SELECT Id, Activity, Description,CreationDate FROM ToDoList";

            SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
            DataSet dataset = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCmd);
            dataAdapter.Fill(dataset);
            // Bind the retrieved data to your DataGridView
            return dataset;

        }


        public static DataSet SearchEntries(string searchTerm, System.DateTime selectedDate)
        {

            // Define your SQL query to search for any word in any row
            string searchQuery = "SELECT Id, Activity, Description, CreationDate FROM ToDoList WHERE Activity LIKE @SearchTerm OR Description LIKE @SearchTerm OR CreationDate LIKE @SearchTerm";

            SqlCommand searchCmd = new SqlCommand(searchQuery, connection);

            // Set the parameter for the search term
            searchCmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

            // Create a new DataTable to store the search results
            DataSet searchResults = new DataSet();

            // Use a SqlDataAdapter to fill the DataTable with the results
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(searchCmd))
            {
                dataAdapter.Fill(searchResults);
            }

            // Bind the search results to your DataGridView
            return searchResults;


        }

        public static void DeleteFromDatabase(string rowId)
        {

            try
            {
                // Define your SQL DELETE query
                string deleteQuery = "DELETE FROM ToDoList WHERE Id = @RowId";

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                {
                    // Set the parameter for the DELETE query
                    deleteCmd.Parameters.AddWithValue("@RowId", rowId);

                    // Execute the DELETE query
                    deleteCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                 

            }
        }

        public static void UpdateDatabase(TodolistModel tmodel)
        {
            string updateQuery = "UPDATE ToDoList SET Activity = @UpdatedActivity, Description = @UpdatedDescription WHERE Id = @RowId";

            using (SqlCommand updateCmd = new(updateQuery, connection))
            {
                // Set the parameters for the update query
                updateCmd.Parameters.AddWithValue("@UpdatedActivity", tmodel.Activity);
                updateCmd.Parameters.AddWithValue("@UpdatedDescription", tmodel.Description);
                updateCmd.Parameters.AddWithValue("@RowId", tmodel.Id);
                updateCmd.ExecuteNonQuery();
            }
        }
    }
}
