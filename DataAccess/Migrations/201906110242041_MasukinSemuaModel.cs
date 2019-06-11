namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MasukinSemuaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_T_Handover",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateHandover = c.DateTimeOffset(nullable: false, precision: 7),
                        Quantity = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Loaning_Id = c.Int(nullable: false),
                        HeadDivision_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_User", t => t.HeadDivision_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_T_Loaning", t => t.Loaning_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id)
                .Index(t => t.Loaning_Id)
                .Index(t => t.HeadDivision_Id);
            
            CreateTable(
                "dbo.TB_M_User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Role = c.Int(nullable: false),
                        HeadDivision_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_Loaning",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateLoaning = c.DateTimeOffset(nullable: false, precision: 7),
                        DateReturn = c.DateTimeOffset(nullable: false, precision: 7),
                        Quantity = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Item", t => t.Item_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Item_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.TB_M_Item",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand = c.String(),
                        Description = c.String(),
                        Condition = c.String(),
                        Image = c.String(),
                        Stock = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Type_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_Type", t => t.Type_Id, cascadeDelete: true)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.TB_M_Type",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TB_T_Procurement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        Admin_Id = c.Int(nullable: false),
                        Item_Id = c.Int(nullable: false),
                        HeadDivision_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_M_User", t => t.Admin_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_M_User", t => t.HeadDivision_Id, cascadeDelete: false)
                .ForeignKey("dbo.TB_M_Item", t => t.Item_Id, cascadeDelete: true)
                .Index(t => t.Admin_Id)
                .Index(t => t.Item_Id)
                .Index(t => t.HeadDivision_Id);
            
            CreateTable(
                "dbo.TB_T_Return",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateReturn = c.DateTimeOffset(nullable: false, precision: 7),
                        LastCondition = c.String(),
                        Quantity = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                        Loaning_Id = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TB_T_Loaning", t => t.Loaning_Id, cascadeDelete: true)
                .ForeignKey("dbo.TB_M_User", t => t.User_Id, cascadeDelete: false)
                .Index(t => t.User_Id)
                .Index(t => t.Loaning_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_Return", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_Return", "Loaning_Id", "dbo.TB_T_Loaning");
            DropForeignKey("dbo.TB_T_Procurement", "Item_Id", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_T_Procurement", "HeadDivision_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_Procurement", "Admin_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_Handover", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_Handover", "Loaning_Id", "dbo.TB_T_Loaning");
            DropForeignKey("dbo.TB_T_Loaning", "User_Id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_T_Loaning", "Item_Id", "dbo.TB_M_Item");
            DropForeignKey("dbo.TB_M_Item", "Type_Id", "dbo.TB_M_Type");
            DropForeignKey("dbo.TB_T_Handover", "HeadDivision_Id", "dbo.TB_M_User");
            DropIndex("dbo.TB_T_Return", new[] { "Loaning_Id" });
            DropIndex("dbo.TB_T_Return", new[] { "User_Id" });
            DropIndex("dbo.TB_T_Procurement", new[] { "HeadDivision_Id" });
            DropIndex("dbo.TB_T_Procurement", new[] { "Item_Id" });
            DropIndex("dbo.TB_T_Procurement", new[] { "Admin_Id" });
            DropIndex("dbo.TB_M_Item", new[] { "Type_Id" });
            DropIndex("dbo.TB_T_Loaning", new[] { "User_Id" });
            DropIndex("dbo.TB_T_Loaning", new[] { "Item_Id" });
            DropIndex("dbo.TB_T_Handover", new[] { "HeadDivision_Id" });
            DropIndex("dbo.TB_T_Handover", new[] { "Loaning_Id" });
            DropIndex("dbo.TB_T_Handover", new[] { "User_Id" });
            DropTable("dbo.TB_T_Return");
            DropTable("dbo.TB_T_Procurement");
            DropTable("dbo.TB_M_Type");
            DropTable("dbo.TB_M_Item");
            DropTable("dbo.TB_T_Loaning");
            DropTable("dbo.TB_M_User");
            DropTable("dbo.TB_T_Handover");
        }
    }
}
