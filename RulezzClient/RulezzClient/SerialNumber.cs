//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class SerialNumber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SerialNumber()
        {
            this.SalesInfo = new HashSet<SalesInfo>();
            this.Warranty = new HashSet<Warranty>();
        }
    
        public int Id { get; set; }
        public string Value { get; set; }
        public Nullable<System.DateTime> SelleDate { get; set; }
        public System.DateTime PurchaseDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesInfo> SalesInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warranty> Warranty { get; set; }
    }
}