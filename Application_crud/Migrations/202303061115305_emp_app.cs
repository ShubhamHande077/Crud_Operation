namespace Application_crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                    ProductId = c.String(nullable: false),
                        categeryName = c.String(nullable: false),
                    categeryId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
