﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jade.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<App_Browse> App_Browse { get; set; }
        public virtual DbSet<Browse_History> Browse_History { get; set; }
        public virtual DbSet<Coupon_Info> Coupon_Info { get; set; }
        public virtual DbSet<Dict> Dict { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Member_Browse_Statistics> Member_Browse_Statistics { get; set; }
        public virtual DbSet<Member_Coupon_Account> Member_Coupon_Account { get; set; }
        public virtual DbSet<Micro_Class_Group> Micro_Class_Group { get; set; }
        public virtual DbSet<Micro_Class_Info> Micro_Class_Info { get; set; }
        public virtual DbSet<Order_Rebate_New> Order_Rebate_New { get; set; }
        public virtual DbSet<Point_Exchange> Point_Exchange { get; set; }
        public virtual DbSet<Point_Exchange_Record> Point_Exchange_Record { get; set; }
        public virtual DbSet<Product_Anti_Fake> Product_Anti_Fake { get; set; }
        public virtual DbSet<Product_Attribute> Product_Attribute { get; set; }
        public virtual DbSet<Product_Browse_Statistics> Product_Browse_Statistics { get; set; }
        public virtual DbSet<Product_Category> Product_Category { get; set; }
        public virtual DbSet<Product_Group> Product_Group { get; set; }
        public virtual DbSet<Product_Info> Product_Info { get; set; }
        public virtual DbSet<Product_Order_Detail> Product_Order_Detail { get; set; }
        public virtual DbSet<Product_Order_Master> Product_Order_Master { get; set; }
        public virtual DbSet<Product_Order_Record> Product_Order_Record { get; set; }
        public virtual DbSet<Product_Pictures> Product_Pictures { get; set; }
        public virtual DbSet<Push_History> Push_History { get; set; }
        public virtual DbSet<Push_Message> Push_Message { get; set; }
        public virtual DbSet<Push_Theme> Push_Theme { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAuthorization> RoleAuthorization { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}