namespace HesapMakinesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gecmis", "sonuc", c => c.String());
            AlterColumn("dbo.Gecmis", "sayi1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Gecmis", "sayi2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Gecmis", "islemler", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gecmis", "islemler", c => c.Int(nullable: false));
            AlterColumn("dbo.Gecmis", "sayi2", c => c.Int(nullable: false));
            AlterColumn("dbo.Gecmis", "sayi1", c => c.Int(nullable: false));
            DropColumn("dbo.Gecmis", "sonuc");
        }
    }
}
