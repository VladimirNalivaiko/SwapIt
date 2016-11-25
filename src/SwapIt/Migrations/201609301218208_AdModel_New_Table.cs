using System.Data.Entity.Migrations;

namespace SwapIt.Migrations
{
    public partial class AdModel_New_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.AdModels",
                    c => new
                    {
                        AdId = c.Long(false, true),
                        Name = c.String(),
                        Description = c.String()
                    })
                .PrimaryKey(t => t.AdId);
        }

        public override void Down()
        {
            DropTable("dbo.AdModels");
        }
    }
}