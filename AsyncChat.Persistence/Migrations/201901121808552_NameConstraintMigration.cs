namespace AsyncChat.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameConstraintMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 8000, unicode: false));
            CreateIndex("dbo.Users", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Name" });
            AlterColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
