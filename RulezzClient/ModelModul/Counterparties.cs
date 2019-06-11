//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ModelModul
{
    public partial class Counterparties
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Counterparties()
        {
            PurchaseReports = new HashSet<PurchaseReports>();
            SalesReports = new HashSet<SalesReports>();
            SerialNumbers = new HashSet<SerialNumbers>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string Props { get; set; }
        public string Address { get; set; }
        public bool WhoIsIt { get; set; }
    
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseReports> PurchaseReports { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReports> SalesReports { get; set; }
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SerialNumbers> SerialNumbers { get; set; }
    }
}