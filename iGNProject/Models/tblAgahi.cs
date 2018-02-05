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
    
    public partial class tblAgahi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAgahi()
        {
            this.tblAgahiHomeDetail = new HashSet<tblAgahiHomeDetail>();
            this.tblAgahiFavorite = new HashSet<tblAgahiFavorite>();
            this.tblAgahiMobCompDetails = new HashSet<tblAgahiMobCompDetails>();
            this.tblAgahiCarDetails = new HashSet<tblAgahiCarDetails>();
        }
    
        public int AgahiID { get; set; }
        public Nullable<int> CategoryAgahiID { get; set; }
        public Nullable<int> AgahiServiceID { get; set; }
        public string AgahiTitle { get; set; }
        public Nullable<bool> NewOrUsed { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string RegisterDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> AdminUserID { get; set; }
        public Nullable<System.DateTime> AdminAgreeDate { get; set; }
        public Nullable<byte> AgahiStatus { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public Nullable<int> LanguageID { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public string Tell { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> PriceTypeID { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> PlanShowAgahiID { get; set; }
        public Nullable<bool> HasImage { get; set; }
        public string Chatable { get; set; }
        public string OnTime { get; set; }
        public Nullable<bool> SpecialAgahi { get; set; }
    
        public virtual tblAgahiCategories tblAgahiCategories { get; set; }
        public virtual tblAgahiPlans tblAgahiPlans { get; set; }
        public virtual tblAgahiService tblAgahiService { get; set; }
        public virtual tblPriceType tblPriceType { get; set; }
        public virtual tblProvince tblProvince { get; set; }
        public virtual tblRegions tblRegions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAgahiHomeDetail> tblAgahiHomeDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAgahiFavorite> tblAgahiFavorite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAgahiMobCompDetails> tblAgahiMobCompDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAgahiCarDetails> tblAgahiCarDetails { get; set; }
    }
}
