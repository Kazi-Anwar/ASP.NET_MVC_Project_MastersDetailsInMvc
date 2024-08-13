namespace MastersDetailsInMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        CatagoryId = c.Int(nullable: false, identity: true),
                        CatogoryName = c.String(),
                    })
                .PrimaryKey(t => t.CatagoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderMasterId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailId)
                .ForeignKey("dbo.OrderMasters", t => t.OrderMasterId, cascadeDelete: true)
                .Index(t => t.OrderMasterId);
            
            CreateTable(
                "dbo.OrderMasters",
                c => new
                    {
                        OrderMasterId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Note = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.OrderMasterId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        CatogoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "OrderMasterId", "dbo.OrderMasters");
            DropIndex("dbo.OrderDetails", new[] { "OrderMasterId" });
            DropTable("dbo.Products");
            DropTable("dbo.OrderMasters");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Catagories");
        }
    }
}
