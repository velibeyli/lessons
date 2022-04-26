namespace SchoolManagementAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationforroleinemp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        GradeId = c.Int(),
                        ClassRoom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId)
                .ForeignKey("dbo.ClassRooms", t => t.ClassRoom_Id)
                .Index(t => t.GradeId)
                .Index(t => t.ClassRoom_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassRoom_Id", "dbo.ClassRooms");
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "ClassRoom_Id" });
            DropIndex("dbo.Students", new[] { "GradeId" });
            DropTable("dbo.Teacher");
            DropTable("dbo.Grades");
            DropTable("dbo.Students");
            DropTable("dbo.ClassRooms");
        }
    }
}
