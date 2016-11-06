namespace RAD301S00151925Clubs.Migrations.ClubMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Member");
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        memberID = c.Int(nullable: false),
                        StudentID = c.String(nullable: false, maxLength: 128),
                        approved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.memberID, t.StudentID });
            
            AlterColumn("dbo.Member", "memberID", c => c.Int(nullable: false));
            AlterColumn("dbo.Member", "StudentID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Member", new[] { "memberID", "StudentID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Member");
            AlterColumn("dbo.Member", "StudentID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Member", "memberID", c => c.Guid(nullable: false));
            DropTable("dbo.Student");
            AddPrimaryKey("dbo.Member", new[] { "memberID", "StudentID" });
        }
    }
}
