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
    
    public partial class NomenclatureGroup : IEquatable<NomenclatureGroup>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NomenclatureGroup()
        {
            this.NomenclatureSubGroup = new HashSet<NomenclatureSubGroup>();
            this.PropertyName = new HashSet<PropertyName>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public int IdStore { get; set; }

        public bool Equals(NomenclatureGroup obj)
        {
            if (this.Id == obj.Id && this.Title == obj.Title && this.IdStore == obj.IdStore) return true;
            else return false;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NomenclatureSubGroup> NomenclatureSubGroup { get; set; }
        public virtual Store Store { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyName> PropertyName { get; set; }
    }
}