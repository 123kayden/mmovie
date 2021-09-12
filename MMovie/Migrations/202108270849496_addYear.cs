namespace MMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Year");
        }
    }
}
