namespace Employee_MVCApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingNewTableForEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TEMPLOYEE",
                c => new
                    {
                        Empid = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        Gender = c.String(),
                        EmailId = c.String(),
                    })
                .PrimaryKey(t => t.Empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TEMPLOYEE");
        }
    }
}
