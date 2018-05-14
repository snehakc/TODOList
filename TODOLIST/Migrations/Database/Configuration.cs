namespace TODOLIST.Migrations.Database
{
    using System.Data.Entity.Migrations;
    using TODOLIST.Context;

    internal sealed class Configuration : DbMigrationsConfiguration<TODOLIST.Context.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Database";
        }

        protected override void Seed(DatabaseContext context)
        {
            // This method will be called after migrating to the latest version.

            // You can use the DbSet<T>.AddOrUpdate() helper extension method to avoid creating duplicate seed data.

            context.ToDoList.AddOrUpdate(
              t => t.Item, DummyData.GetItems().ToArray());
            context.ToDoList.AddOrUpdate(
                t => t.Item, DummyData.GetItems().ToArray());
            context.ToDoList.AddOrUpdate(
              t => t.Priority, DummyData.GetItems().ToArray());
            context.ToDoList.AddOrUpdate(
              t => t.IsCompleted, DummyData.GetItems().ToArray());
            context.SaveChanges();
        }
    }
}