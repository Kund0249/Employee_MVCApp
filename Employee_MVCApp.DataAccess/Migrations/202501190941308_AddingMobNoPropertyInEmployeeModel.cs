namespace Employee_MVCApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMobNoPropertyInEmployeeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TEMPLOYEE", "MobNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TEMPLOYEE", "MobNo");
        }
    }
}
