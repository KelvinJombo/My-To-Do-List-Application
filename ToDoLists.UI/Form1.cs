using System.Data;
using System.Data.SqlClient;
using ToDoList5.Data;
using ToDoList5.Model;

namespace ToDoLists.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connection.Connect();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewAllRecords();
        }


        //private int 
        private void editButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                TodolistModel tmodel = new TodolistModel()
                {
                    Id = int.Parse(idtxt.Text),
                    Activity = textBox2.Text,
                    Description = textBox1.Text
                };
                Repository.UpdateDatabase(tmodel);
                Reset();
                MessageBox.Show("Update successful");
                isEditing = false;
            }
            else
            {
                if (toDoListView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = toDoListView.SelectedRows[0];

                    // Get the values from the selected row
                    int rowId = Convert.ToInt32(selectedRow.Cells["Id"].Value); // Assuming "Id" is the primary key

                    // Populate your editing controls (text fields) with the selected row's data
                    textBox2.Text = selectedRow.Cells["Activity"].Value.ToString();
                    textBox1.Text = selectedRow.Cells["Description"].Value.ToString();
                    idtxt.Text = selectedRow.Cells["Id"].Value.ToString();

                    isEditing = true;
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        }
        public void ViewAllRecords()
        {
            toDoListView.DataSource = Repository.ViewRecords().Tables[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TodolistModel tmodel = new TodolistModel()
            {
                Activity = textBox2.Text,
                Description = textBox1.Text,
                CreationDate = dateTimePicker1.Value
            };

            Repository.SaveToDatabase(tmodel);
            Reset();
            ViewAllRecords();
            MessageBox.Show("Data saved successfully");

        }

        private void Reset()
        {
            idtxt.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            ViewAllRecords();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Get the search term from a TextBox or any other control
            string searchTerm = searchTextBox.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value.Date;
            // Call the search method with the search term
            toDoListView.DataSource = Repository.SearchEntries(searchTerm, selectedDate).Tables[0];
        }




        private void selectAllButton_Click(object sender, EventArgs e)
        {

            // Select all rows in the DataGridView
            foreach (DataGridViewRow row in toDoListView.Rows)
            {
                row.Selected = true;
            }

        }




        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (toDoListView.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = toDoListView.SelectedRows[0];

                string rowId = selectedRow.Cells["Id"].Value.ToString();

                // Update the database to delete the corresponding row
                Repository.DeleteFromDatabase(rowId);
                Reset();
                ViewAllRecords();
                MessageBox.Show("Data deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchTextBox.Text == "")
            {
                ViewAllRecords();
            }
        }
    }
}