//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iGNProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAgahiBrandMobileCopmuter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAgahiBrandMobileCopmuter()
        {
            this.tblAgahiMobCompDetails = new HashSet<tblAgahiMobCompDetails>();
        }
    
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public Nullable<int> ParrentID { get; set; }
        public Nullable<bool> Mobile { get; set; }
        public Nullable<bool> Computer { get; set; }
        public Nullable<bool> AllinOne { get; set; }
        public Nullable<bool> Labtop { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAgahiMobCompDetails> tblAgahiMobCompDetails { get; set; }
    }
}