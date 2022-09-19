namespace Entity_FrameWork_CodeFirst_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EF_Shu_Students", newName: "Students");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Students", newName: "EF_Shu_Students");
        }
    }
}
