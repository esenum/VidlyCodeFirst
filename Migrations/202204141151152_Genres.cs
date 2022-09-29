namespace VidlyCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Action')");
        }
        
        public override void Down()
        {
        }
    }
}
