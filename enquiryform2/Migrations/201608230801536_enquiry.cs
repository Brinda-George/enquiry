namespace enquiryform2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enquiry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.enquiries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Comments = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.enquiries");
        }
    }
}
