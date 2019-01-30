﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RulezzClient
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StoreEntities : DbContext
    {
        public StoreEntities()
            : base("name=StoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }
        public virtual DbSet<NomenclatureGroup> NomenclatureGroup { get; set; }
        public virtual DbSet<NomenclatureSubGroup> NomenclatureSubGroup { get; set; }
        public virtual DbSet<PriceGroup> PriceGroup { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<PropertyName> PropertyName { get; set; }
        public virtual DbSet<PropertyProduct> PropertyProduct { get; set; }
        public virtual DbSet<PropertyValue> PropertyValue { get; set; }
        public virtual DbSet<PurchaseInfo> PurchaseInfo { get; set; }
        public virtual DbSet<PurchaseReport> PurchaseReport { get; set; }
        public virtual DbSet<RevaluationProduct> RevaluationProduct { get; set; }
        public virtual DbSet<SalesInfo> SalesInfo { get; set; }
        public virtual DbSet<SalesReport> SalesReport { get; set; }
        public virtual DbSet<SerialNumber> SerialNumber { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<UnitStorage> UnitStorage { get; set; }
        public virtual DbSet<Warranty> Warranty { get; set; }
        public virtual DbSet<WarrantyPeriod> WarrantyPeriod { get; set; }
    
        [DbFunction("StoreEntities", "AllProductView")]
        public virtual IQueryable<AllProductView_Result> AllProductView()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<AllProductView_Result>("[StoreEntities].[AllProductView]()");
        }
    
        [DbFunction("StoreEntities", "ProductView")]
        public virtual IQueryable<ProductView_Result> ProductView(Nullable<int> idNomenclatureSubGroup)
        {
            var idNomenclatureSubGroupParameter = idNomenclatureSubGroup.HasValue ?
                new ObjectParameter("idNomenclatureSubGroup", idNomenclatureSubGroup) :
                new ObjectParameter("idNomenclatureSubGroup", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ProductView_Result>("[StoreEntities].[ProductView](@idNomenclatureSubGroup)", idNomenclatureSubGroupParameter);
        }
    }
}
