namespace VarBal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class products : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Shipments", "SenderId");
            CreateIndex("dbo.Shipments", "ReceiverId");
            AddForeignKey("dbo.Shipments", "ReceiverId", "dbo.Warehouses", "Id");
            AddForeignKey("dbo.Shipments", "SenderId", "dbo.Warehouses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shipments", "SenderId", "dbo.Warehouses");
            DropForeignKey("dbo.Shipments", "ReceiverId", "dbo.Warehouses");
            DropIndex("dbo.Shipments", new[] { "ReceiverId" });
            DropIndex("dbo.Shipments", new[] { "SenderId" });
        }
    }
}
