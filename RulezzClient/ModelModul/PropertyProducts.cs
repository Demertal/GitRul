//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelModul
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyProducts
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdPropertyValue { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual PropertyValues PropertyValues { get; set; }
    }
}
