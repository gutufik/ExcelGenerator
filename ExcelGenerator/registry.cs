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
    
    public partial class registry
    {
        public int id { get; set; }
        public int category_id { get; set; }
        public System.DateTime date { get; set; }
        public int money { get; set; }
        public string comment { get; set; }
        public Nullable<System.DateTime> amortization_end { get; set; }
        public Nullable<byte> is_withdraw { get; set; }
        public Nullable<System.DateTime> credit_end { get; set; }
        public Nullable<short> credit_rate { get; set; }
        public Nullable<int> shop_id { get; set; }
    
        public virtual category category { get; set; }
    }
}
