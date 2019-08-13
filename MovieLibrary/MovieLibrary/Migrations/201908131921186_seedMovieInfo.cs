namespace MovieLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedMovieInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "DirectorName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "DirectorName");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
