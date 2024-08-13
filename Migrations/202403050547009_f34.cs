namespace MastersDetailsInMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f34 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CatogoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CatogoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "CategoryId");
        }
    }
}
