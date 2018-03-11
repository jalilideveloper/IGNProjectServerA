using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace iGNProject.Models.RelApiClass
{
    public class Agahi
    {
            public int AgahiID { get; set; }
            public Nullable<int> CategoryAgahiID { get; set; }
            public Nullable<int> AgahiServiceID { get; set; }
            public string AgahiTitle { get; set; }
            //public Nullable<bool> NewOrUsed { get; set; }
            public string Description { get; set; }
            //public string Keyword { get; set; }
            public string RegisterDate { get; set; }
            public Nullable<int> UserID { get; set; }
            public Nullable<int> AdminUserID { get; set; }
            public Nullable<System.DateTime> AdminAgreeDate { get; set; }
            public Nullable<byte> AgahiStatus { get; set; }
            public DbGeography Location { get; set; }
            public Nullable<int> LanguageID { get; set; }
            public Nullable<int> CityID { get; set; }
            public Nullable<int> RegionID { get; set; }
            public string Tell { get; set; }
            public string Mobile { get; set; }
            public Nullable<int> PriceTypeID { get; set; }
            public Nullable<decimal> Price { get; set; }
            public Nullable<int> PlanShowAgahiID { get; set; }
            public Nullable<bool> HasImage { get; set; }
            public bool ? Chatable { get; set; }
            public string OnTime { get; set; }
            public Nullable<bool> SpecialAgahi { get; set; }

        
    }
}