namespace Rc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Costs",
                c => new
                    {
                        CostID = c.Int(nullable: false, identity: true),
                        Column_A = c.String(nullable: false, maxLength: 50),
                        Column_B = c.String(maxLength: 50),
                        Column_C = c.String(nullable: false, maxLength: 50),
                        Column_D = c.String(nullable: false, maxLength: 50),
                        Column_E = c.String(nullable: false, maxLength: 50),
                        Column_F = c.String(nullable: false, maxLength: 50),
                        Column_G = c.Double(nullable: false),
                        Column_H = c.String(nullable: false, maxLength: 50),
                        Column_I = c.String(nullable: false, maxLength: 50),
                        Column_J = c.String(nullable: false, maxLength: 50),
                        Column_K = c.String(nullable: false, maxLength: 50),
                        Column_L = c.String(nullable: false, maxLength: 50),
                        Column_M = c.String(nullable: false, maxLength: 50),
                        Column_N = c.String(nullable: false, maxLength: 50),
                        Column_O = c.String(nullable: false, maxLength: 50),
                        Column_P = c.String(nullable: false, maxLength: 50),
                        Column_Q = c.String(nullable: false, maxLength: 50),
                        Column_R = c.String(nullable: false, maxLength: 50),
                        Column_S = c.String(nullable: false, maxLength: 50),
                        Column_T = c.String(nullable: false, maxLength: 50),
                        Column_U = c.String(nullable: false, maxLength: 50),
                        Column_V = c.String(nullable: false, maxLength: 50),
                        Column_W = c.String(nullable: false, maxLength: 50),
                        Column_X = c.String(nullable: false, maxLength: 50),
                        Column_Y = c.String(nullable: false, maxLength: 50),
                        Column_Z = c.DateTime(nullable: false),
                        Column_AA = c.DateTime(nullable: false),
                        Column_AB = c.DateTime(nullable: false),
                        Column_AC = c.String(nullable: false, maxLength: 50),
                        Column_AD = c.Double(nullable: false),
                        Column_AE = c.String(nullable: false, maxLength: 50),
                        Column_AF = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CostID);
            
            CreateTable(
                "dbo.Revenues",
                c => new
                    {
                        RevenueID = c.Int(nullable: false, identity: true),
                        Column_A = c.String(nullable: false, maxLength: 50),
                        Column_B = c.String(maxLength: 50),
                        Column_C = c.String(nullable: false, maxLength: 50),
                        Column_D = c.String(nullable: false, maxLength: 50),
                        Column_E = c.Double(nullable: false),
                        Column_F = c.String(nullable: false, maxLength: 50),
                        Column_G = c.String(nullable: false, maxLength: 50),
                        Column_H = c.String(nullable: false, maxLength: 50),
                        Column_I = c.String(nullable: false, maxLength: 50),
                        Column_J = c.DateTime(nullable: false),
                        Column_K = c.DateTime(nullable: false),
                        Column_L = c.String(nullable: false, maxLength: 50),
                        Column_M = c.String(nullable: false, maxLength: 50),
                        Column_N = c.String(nullable: false, maxLength: 50),
                        Column_O = c.String(nullable: false, maxLength: 50),
                        Column_P = c.Double(nullable: false),
                        Column_Q = c.String(nullable: false, maxLength: 50),
                        Column_R = c.Double(nullable: false),
                        Column_S = c.String(nullable: false, maxLength: 50),
                        Column_T = c.String(nullable: false, maxLength: 50),
                        Column_U = c.String(nullable: false, maxLength: 50),
                        Column_V = c.String(nullable: false, maxLength: 50),
                        Column_W = c.String(nullable: false, maxLength: 50),
                        Column_X = c.String(nullable: false, maxLength: 50),
                        Column_Y = c.String(nullable: false, maxLength: 50),
                        Column_Z = c.String(nullable: false, maxLength: 50),
                        Column_AA = c.String(nullable: false, maxLength: 50),
                        Column_AB = c.String(nullable: false, maxLength: 50),
                        Column_AC = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RevenueID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Revenues");
            DropTable("dbo.Costs");
        }
    }
}
