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
    
    public partial class GetByIdRss_Result
    {
        public int RssID { get; set; }
        public string RssUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<int> RssTypeID { get; set; }
    }
}