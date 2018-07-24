namespace Superhero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Superheroes");
            AddColumn("dbo.Superheroes", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Superheroes", "Name", c => c.String());
            AddPrimaryKey("dbo.Superheroes", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Superheroes");
            AlterColumn("dbo.Superheroes", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Superheroes", "ID");
            AddPrimaryKey("dbo.Superheroes", "Name");
        }
    }
}
