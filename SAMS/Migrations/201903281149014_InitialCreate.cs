namespace SAMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseUnits",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Grade = c.Int(),
                        CourseUnit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CourseUnits", t => t.CourseUnit_Id)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseUnit_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Enrollments", "CourseUnit_Id", "dbo.CourseUnits");
            DropIndex("dbo.Enrollments", new[] { "CourseUnit_Id" });
            DropIndex("dbo.Enrollments", new[] { "StudentID" });
            DropTable("dbo.Students");
            DropTable("dbo.Enrollments");
            DropTable("dbo.CourseUnits");
        }
    }
}
