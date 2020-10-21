namespace POMACSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "OtherNames", c => c.String());
            AddColumn("dbo.AspNetUsers", "PrisonID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PrisonID");
            DropColumn("dbo.AspNetUsers", "OtherNames");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
