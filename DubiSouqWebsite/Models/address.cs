//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DubiSouqWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class address
    {
        public int ID { get; set; }
        public Nullable<int> Zipcode { get; set; }
        public string Address1 { get; set; }
        public int User_ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    
        public virtual user user { get; set; }
    }
}
