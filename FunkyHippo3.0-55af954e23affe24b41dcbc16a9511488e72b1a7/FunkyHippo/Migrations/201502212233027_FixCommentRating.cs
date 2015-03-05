namespace FunkyHippo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixCommentRating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Review", "Comment", c => c.String(maxLength: 140));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Review", "Comment", c => c.String());
        }
    }
}
