//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOVOICE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public long id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<long> fk_ads { get; set; }
        public Nullable<long> fk_debates { get; set; }
        public Nullable<long> fk_feedback { get; set; }
        public string username { get; set; }
        public string IMG { get; set; }
    }
}
