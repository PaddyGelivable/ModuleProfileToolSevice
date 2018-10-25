namespace ModuleProfileToolSevice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ModuleInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VendorName = c.String(nullable: false),
                        ModuleID = c.String(),
                        ProductCode = c.Int(nullable: false),
                        VendorID = c.Int(nullable: false),
                        ProductType = c.Int(nullable: false),
                        CatalogName = c.String(),
                        ModuleRevision = c.String(),
                        ModuleSeries = c.String(),
                        ProfileRevision = c.String(),
                        MaximumBaudRate = c.String(),
                        MinFWVersion = c.Int(nullable: false),
                        InputWord = c.Int(nullable: false),
                        OutPutWord = c.Int(nullable: false),
                        Description = c.String(),
                        MaximumLength = c.Int(nullable: false),
                        FilePath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ModuleInfoes");
        }
    }
}
