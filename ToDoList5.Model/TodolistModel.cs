namespace ToDoList5.Model
{
    public class TodolistModel
    {
        public int Id { get; set; } 
        public string Activity { get; set; }
        public string Description { get; set; }   
        public DateTime CreationDate { get; set; }
    }
}