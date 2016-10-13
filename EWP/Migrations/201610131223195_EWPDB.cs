namespace EWP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EWPDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Joints",
                c => new
                    {
                        JointID = c.Int(nullable: false, identity: true),
                        JointName = c.String(),
                    })
                .PrimaryKey(t => t.JointID);
            
            CreateTable(
                "dbo.Muscles",
                c => new
                    {
                        MuscleID = c.Int(nullable: false, identity: true),
                        MuscleName = c.String(),
                    })
                .PrimaryKey(t => t.MuscleID);
            
            
            
            
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        SportID = c.Int(nullable: false, identity: true),
                        SportName = c.String(),
                        SportType = c.String(),
                    })
                .PrimaryKey(t => t.SportID);
            
            
            
           
            
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        WorkoutID = c.Int(nullable: false, identity: true),
                        WorkoutName = c.String(),
                        Difficaulty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkoutID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.Workouts");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Sports");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Muscles");
            DropTable("dbo.Joints");
            DropTable("dbo.Bones");
        }
    }
}
