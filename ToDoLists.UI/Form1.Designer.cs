namespace ToDoLists.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            descriptionTextBox = new Label();
            textBox2 = new TextBox();
            activityTextBox = new Label();
            button1 = new Button();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            selectAllButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            toDoListView = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            idtxt = new Label();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, -2);
            label1.Name = "label1";
            label1.Size = new Size(1024, 70);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1016, 31);
            textBox1.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            descriptionTextBox.Location = new Point(60, 138);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(230, 38);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1016, 31);
            textBox2.TabIndex = 9;
            // 
            // activityTextBox
            // 
            activityTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            activityTextBox.Location = new Point(64, 63);
            activityTextBox.Name = "activityTextBox";
            activityTextBox.Size = new Size(176, 35);
            activityTextBox.TabIndex = 10;
            activityTextBox.Text = "Activity";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(55, 211);
            button1.Name = "button1";
            button1.Size = new Size(158, 34);
            button1.TabIndex = 11;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.InactiveCaption;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(262, 211);
            addButton.Name = "addButton";
            addButton.Size = new Size(161, 34);
            addButton.TabIndex = 12;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.InactiveCaption;
            editButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editButton.Location = new Point(479, 211);
            editButton.Name = "editButton";
            editButton.Size = new Size(172, 34);
            editButton.TabIndex = 13;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.InactiveCaption;
            deleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Location = new Point(700, 211);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(167, 34);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // selectAllButton
            // 
            selectAllButton.BackColor = SystemColors.InactiveCaption;
            selectAllButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            selectAllButton.Location = new Point(916, 211);
            selectAllButton.Name = "selectAllButton";
            selectAllButton.Size = new Size(154, 34);
            selectAllButton.TabIndex = 15;
            selectAllButton.Text = "SELECT ALL";
            selectAllButton.UseVisualStyleBackColor = false;
            selectAllButton.Click += selectAllButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.Highlight;
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            searchButton.Location = new Point(760, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(102, 34);
            searchButton.TabIndex = 16;
            searchButton.Text = "SEARCH";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(869, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(150, 31);
            searchTextBox.TabIndex = 17;
            searchTextBox.KeyUp += searchTextBox_KeyUp;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = SystemColors.Info;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.GridColor = SystemColors.ControlText;
            toDoListView.Location = new Point(52, 253);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 62;
            toDoListView.RowTemplate.Height = 33;
            toDoListView.Size = new Size(1019, 378);
            toDoListView.TabIndex = 18;
            toDoListView.CellContentClick += toDoListView_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(770, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 19;
            // 
            // idtxt
            // 
            idtxt.AutoSize = true;
            idtxt.Location = new Point(964, 147);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(59, 25);
            idtxt.TabIndex = 20;
            idtxt.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1112, 667);
            Controls.Add(idtxt);
            Controls.Add(dateTimePicker1);
            Controls.Add(toDoListView);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(selectAllButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(button1);
            Controls.Add(activityTextBox);
            Controls.Add(textBox2);
            Controls.Add(descriptionTextBox);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ToDoList";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label descriptionTextBox;
        private TextBox textBox2;
        private Label activityTextBox;
        private Button button1;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button selectAllButton;
        private Button searchButton;
        private TextBox searchTextBox;
        private DataGridView toDoListView;
        private DateTimePicker dateTimePicker1;
        private Label idtxt;
    }
}