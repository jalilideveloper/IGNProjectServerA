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
    
    public partial class tblCarSokht
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCarSokht()
        {
            this.tblAgahiCarDetails = new HashSet<tblAgahiCarDetails>();
        }
    
        public int SokhtID { get; set; }
        public string SokhName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAgahiCarDetails> tblAgahiCarDetails { get; set; }
    }
}
