namespace SLTConsumerTicketing.Web.Api.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddNo = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NID = c.String(),
                        Email = c.String(),
                        PersonType = c.Int(nullable: false),
                        IsCustomerVisible = c.Boolean(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Address_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .Index(t => t.Address_Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        CustomerId = c.Int(nullable: false),
                        AssignedId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EstimatedDate = c.DateTime(nullable: false),
                        ClosedDate = c.DateTime(nullable: false),
                        Severity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.People", new[] { "Address_Id" });
            DropTable("dbo.Tickets");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
        }
    }
}
