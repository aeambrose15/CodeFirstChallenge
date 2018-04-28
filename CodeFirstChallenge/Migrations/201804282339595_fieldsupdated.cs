namespace CodeFirstChallenge.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fieldsupdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "RegNo", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "RegNo", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
