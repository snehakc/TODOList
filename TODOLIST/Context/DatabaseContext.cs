using System.Data.Entity;
using TODOLIST.Models;

namespace TODOLIST.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {
        }

        public DbSet<ToDoModel> ToDoList { get; set; }
    }
}