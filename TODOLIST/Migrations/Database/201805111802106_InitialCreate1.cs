namespace TODOLIST.Migrations.Database
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToDoModels", "IsCompleted", c => c.Boolean(nullable: false));
            DropColumn("dbo.ToDoModels", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoModels", "IsActive", c => c.Int(nullable: false));
            AlterColumn("dbo.ToDoModels", "IsCompleted", c => c.Int(nullable: false));
        }
    }
}
