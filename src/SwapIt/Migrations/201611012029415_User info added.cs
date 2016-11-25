using System.Data.Entity.Migrations;

namespace SwapIt.Migrations
{
    public partial class Userinfoadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.RoleViewModels",
                    c => new
                    {
                        Id = c.String(false, 128),
                        Name = c.String(false)
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.RoleViewModels");
        }
    }
}