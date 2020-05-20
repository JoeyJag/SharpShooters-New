namespace Sharpshooter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "MenuItemImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "MenuItemImg");
        }
    }
}
