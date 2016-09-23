namespace EmployeeWcfServiceApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "DateOfJoining", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "DateOfJoining", c => c.DateTime(nullable: false));
        }
    }
}
