using System.Data.Entity.Migrations;

namespace SwapIt.Migrations
{
    public partial class Adsowneradded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdModels", "Owner", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.AdModels", "Owner");
        }
    }
}