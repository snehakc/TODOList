using System.Collections.Generic;
using TODOLIST.Models;

namespace TODOLIST.Context
{
    public class DummyData
    {
        public static List<ToDoModel> GetItems()
        {
            List<ToDoModel> items = new List<ToDoModel>() {
                new ToDoModel
                {
                    Id =1,
                    Priority = Priority.High,
                    Item = "Buy Milk",
                    IsCompleted = false
                },
                new ToDoModel
                {
                    Id =2,
                    Priority = Priority.Low,
                    Item = "Pickup shoes",
                    IsCompleted = true,
                },
            };
            return items;
        }
    }
}