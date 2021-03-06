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
    
    public partial class tblAgahiCarDetails
    {
        public int AgahiDetailCarID { get; set; }
        public Nullable<int> AgahiID { get; set; }
        public string karkardDaghigh { get; set; }
        public Nullable<int> SaleSakht { get; set; }
        public Nullable<bool> GirboxAuto { get; set; }
        public Nullable<int> SokhtID { get; set; }
        public Nullable<int> CarColorIDInside { get; set; }
        public Nullable<int> CarColorIDOutSide { get; set; }
        public Nullable<int> CarTipID { get; set; }
        public Nullable<int> MotorHajmID { get; set; }
        public Nullable<int> AirBagNumber { get; set; }
        public Nullable<int> DandehNumber { get; set; }
        public Nullable<bool> SunRoof { get; set; }
        public Nullable<bool> Remote { get; set; }
        public Nullable<bool> SandaliBarghi { get; set; }
        public Nullable<int> SopapID { get; set; }
        public Nullable<decimal> PishPardakht { get; set; }
        public Nullable<decimal> Mahane { get; set; }
        public Nullable<decimal> MablagheKole { get; set; }
        public Nullable<int> RokeshTypeID { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> CarConditionID { get; set; }
        public Nullable<int> CarChassisTypeID { get; set; }
        public Nullable<byte> DiffType { get; set; }
        public Nullable<int> CarBodyStatusID { get; set; }
        public Nullable<int> CarPelakTypeID { get; set; }
        public Nullable<bool> HasAlarm { get; set; }
        public Nullable<bool> HasSound { get; set; }
        public Nullable<int> CarCrashTypeID { get; set; }
    
        public virtual tblBrands tblBrands { get; set; }
        public virtual tblCarBodyStatus tblCarBodyStatus { get; set; }
        public virtual tblCarChassis tblCarChassis { get; set; }
        public virtual tblCarColors tblCarColors { get; set; }
        public virtual tblCarColors tblCarColors1 { get; set; }
        public virtual tblCarConditions tblCarConditions { get; set; }
        public virtual tblCarCrash tblCarCrash { get; set; }
        public virtual tblCarMotorHajme tblCarMotorHajme { get; set; }
        public virtual tblCarPelak tblCarPelak { get; set; }
        public virtual tblCarSokht tblCarSokht { get; set; }
        public virtual tblCarSopapMotor tblCarSopapMotor { get; set; }
        public virtual tblCarTip tblCarTip { get; set; }
        public virtual tblAgahi tblAgahi { get; set; }
    }
}
