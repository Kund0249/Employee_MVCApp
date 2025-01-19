namespace Employee_MVCApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDataBaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        SystemNumber = c.Int(nullable: false, identity: true),
                        DepartmentCode = c.String(),
                        DepartmentName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SystemNumber);
            
            CreateTable(
                "dbo.TFILEINFO",
                c => new
                    {
                        SystemNumber = c.Int(nullable: false, identity: true),
                        ContentName = c.String(),
                        FileName = c.String(),
                        FilePath = c.String(),
                    })
                .PrimaryKey(t => t.SystemNumber);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        EmailAddress = c.String(),
                        Mobile = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserEntities");
            DropTable("dbo.TFILEINFO");
            DropTable("dbo.Departments");
        }
    }
}
