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
    }
}
