namespace SwapIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdModel_New_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdModels",
                c => new
                    {
                        AdId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AdId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdModels");
        }
    }
}
