//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExcelGenerator
{
    using System;
    using System.Collections.Generic;
    
    public partial class category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public category()
        {
            this.category1 = new HashSet<category>();
            this.category_history = new HashSet<category_history>();
            this.registry = new HashSet<registry>();
        }
    
        public int id { get; set; }
        public Nullable<int> parent_id { get; set; }
        public int activity_id { get; set; }
        public string title { get; set; }
        public byte is_income { get; set; }
        public byte is_direct_expense { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
        public byte is_main { get; set; }
        public Nullable<int> shop_id { get; set; }
    
        public virtual activity activity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<category> category1 { get; set; }
        public virtual category category2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<category_history> category_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<registry> registry { get; set; }
    }
}
