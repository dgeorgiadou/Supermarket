namespace DatabaseData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KPI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KPIs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Upthreshold = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Dowmthreshold = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Goal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KPIs");
        }
    }
}
