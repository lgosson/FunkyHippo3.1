namespace FunkyHippo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.User", "SurName", c => c.String(maxLength: 50));
            AlterColumn("dbo.User", "FirstName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "FirstName", c => c.String());
            AlterColumn("dbo.User", "SurName", c => c.String());
            AlterColumn("dbo.User", "UserName", c => c.String());
        }
    }
}
