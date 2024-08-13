namespace MastersDetailsInMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f3434 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CatogoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CatagoryId");
            DropTable("dbo.Catagories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        CatagoryId = c.Int(nullable: false, identity: true),
                        CatogoryName = c.String(),
                    })
                .PrimaryKey(t => t.CatagoryId);
            
            AddColumn("dbo.Products", "CatagoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CategoryId");
            DropTable("dbo.Categories");
        }
    }
}
