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
    
    public partial class tblAgahiGalleries
    {
        public int GalleryID { get; set; }
        public Nullable<int> AgahiID { get; set; }
        public string ImageAddress { get; set; }
    
        public virtual tblAgahi tblAgahi { get; set; }
    }
}
