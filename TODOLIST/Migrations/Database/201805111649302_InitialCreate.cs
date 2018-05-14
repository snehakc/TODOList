namespace TODOLIST.Migrations.Database
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Down()
        {
            DropTable("dbo.ToDoModels");
        }

        public override void Up()
        {
            CreateTable(
                "dbo.ToDoModels",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    IsActive = c.Int(nullable: false),
                    IsCompleted = c.Int(nullable: false),
                    Item = c.String(),
                    Priority = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }
    }
}