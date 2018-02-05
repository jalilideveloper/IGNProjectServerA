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
    
    public partial class tblAgahiHomeDetail
    {
        public int AgahiDetailHomeID { get; set; }
        public int AgahiID { get; set; }
        public string CodeMelk { get; set; }
        public Nullable<bool> Parking { get; set; }
        public Nullable<bool> Asansor { get; set; }
        public Nullable<int> OtaghKhab { get; set; }
        public Nullable<int> ServiceIrani { get; set; }
        public Nullable<int> ServiceKhareji { get; set; }
        public Nullable<int> SaleSakht { get; set; }
        public Nullable<int> Tabaghe { get; set; }
        public Nullable<int> MelkTypeID { get; set; }
        public Nullable<int> GharardadTypeID { get; set; }
        public Nullable<int> Zirbana { get; set; }
        public Nullable<decimal> MablagheKole { get; set; }
        public Nullable<decimal> MablagheMahane { get; set; }
        public Nullable<int> MantagheID { get; set; }
        public Nullable<bool> Balkon { get; set; }
        public Nullable<bool> Estakhr { get; set; }
        public Nullable<bool> Zirzamin { get; set; }
        public Nullable<bool> Hayat { get; set; }
        public Nullable<int> NSEWID { get; set; }
        public Nullable<bool> Sona { get; set; }
        public Nullable<bool> Jakozi { get; set; }
        public Nullable<bool> Khabmaster { get; set; }
        public Nullable<bool> Roofgarden { get; set; }
        public Nullable<bool> Chiler { get; set; }
        public Nullable<bool> Barbikio { get; set; }
        public Nullable<bool> Alachigh { get; set; }
        public Nullable<bool> Labi { get; set; }
        public Nullable<bool> MohavateBaziKodak { get; set; }
        public Nullable<int> JeneskafID { get; set; }
        public Nullable<bool> Badansazi { get; set; }
        public Nullable<bool> Varaseiye { get; set; }
        public Nullable<bool> TakBarg { get; set; }
        public Nullable<bool> Vam { get; set; }
        public Nullable<decimal> Mablaghevam { get; set; }
        public Nullable<int> GarmayeshTypeID { get; set; }
    
        public virtual tblAgahi tblAgahi { get; set; }
        public virtual tblHomeGarmayeshType tblHomeGarmayeshType { get; set; }
        public virtual tblHomeGharardad tblHomeGharardad { get; set; }
        public virtual tblHomeJenesKafID tblHomeJenesKafID { get; set; }
        public virtual tblHomeMantagheID tblHomeMantagheID { get; set; }
        public virtual tblHomeMelkType tblHomeMelkType { get; set; }
        public virtual tblHomeNSEWID tblHomeNSEWID { get; set; }
    }
}