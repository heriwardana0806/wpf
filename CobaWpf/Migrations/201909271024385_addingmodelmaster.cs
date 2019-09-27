namespace CobaWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelmaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_M_Student",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Class = c.String(),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.TB_M_Teacher", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.TB_M_Teacher",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_M_Student", "TeacherId", "dbo.TB_M_Teacher");
            DropIndex("dbo.Tb_M_Student", new[] { "TeacherId" });
            DropTable("dbo.TB_M_Teacher");
            DropTable("dbo.Tb_M_Student");
        }
    }
}
