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
    
    public partial class tblAgahiMobCompDetails
    {
        public int AgahiMobCopID { get; set; }
        public Nullable<int> AgahiID { get; set; }
        public Nullable<int> Ram { get; set; }
        public Nullable<int> Cpu { get; set; }
        public Nullable<int> Graphic { get; set; }
        public Nullable<bool> LCD { get; set; }
        public Nullable<bool> LED { get; set; }
        public Nullable<bool> Four4K { get; set; }
        public Nullable<bool> Touch { get; set; }
        public Nullable<double> DisplaySize { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<bool> LabTop { get; set; }
        public Nullable<bool> Mobile { get; set; }
        public Nullable<bool> AllinOne { get; set; }
        public Nullable<bool> Garanti { get; set; }
        public Nullable<bool> Waranty { get; set; }
        public Nullable<bool> AntiWater { get; set; }
        public Nullable<int> JeansBadaneID { get; set; }
        public Nullable<bool> USB3 { get; set; }
        public Nullable<int> HDDMeasure { get; set; }
        public Nullable<int> SSDMeasure { get; set; }
        public Nullable<bool> HasHHD { get; set; }
        public Nullable<bool> HasSSD { get; set; }
        public Nullable<bool> HasUSB3 { get; set; }
        public Nullable<bool> HasDVDRW { get; set; }
        public Nullable<int> ColorID { get; set; }
        public Nullable<bool> HasCamera { get; set; }
        public Nullable<int> CameraMgeaPixel { get; set; }
    
        public virtual tblBrands tblBrands { get; set; }
        public virtual tblJeansBadane tblJeansBadane { get; set; }
        public virtual tblAgahi tblAgahi { get; set; }
    }
}
