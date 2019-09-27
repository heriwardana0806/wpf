namespace CobaWpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelmaster1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_M_User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Contact = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tb_M_User");
        }
    }
}
