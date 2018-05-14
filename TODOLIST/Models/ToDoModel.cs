using System.ComponentModel.DataAnnotations;

namespace TODOLIST.Models
{
    public enum Priority
    {
        Low, Medium, High
    }

    public class ToDoModel
    {
        public int Id { get; set; }
        public bool IsCompleted { get; set; }

        [Required(ErrorMessage = "Enter a ToDo Item")]
        public string Item { get; set; }

        public Priority Priority { get; set; }
    }
}