﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaymentPlans
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PaymentPlansEntities : DbContext
    {
        public PaymentPlansEntities()
            : base("name=PaymentPlansEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<PlanMaster> PlanMasters { get; set; }
    
        public virtual ObjectResult<PaymentPlansReport_Result> PaymentPlansReport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaymentPlansReport_Result>("PaymentPlansReport");
        }
    
        public virtual ObjectResult<PaymentDetails_SelectAll_Result> PaymentDetails_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PaymentDetails_SelectAll_Result>("PaymentDetails_SelectAll");
        }
    }
}