﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace iGNProject.Models.AdsRegistration
{

    public class RegisterCarHeavys
    {
        //Fixed
        //lvl1 Or lvl2   latest
        public int CategoryID { get; set; }
        public int CityID { get; set; }
        public int RegionID { get; set; }
        public DbGeography Location { get; set; }

        //Kind => AgahiServiceID
        public int AgahiServiceID { get; set; }
        public string TitleAgahi { get; set; }
        public string uploadimageone { get; set; }
        public string uploadimagetwo { get; set; }
        public string uploadimagethree { get; set; }
        public string uploadimagefour { get; set; }
        public string AgahiDescription { get; set; }

        public string AdvertiserFullName { get; set; }
        public string AdvertiserEmail { get; set; }
        public string AdvertiserMobile { get; set; }
        public int KindAdsID { get; set; }
        public string RegisterDate { get; set; }
        public int UserID { get; set; }
        public int LanguageID { get; set; }
        public bool? Chatable { get; set; }
        public string OnTime { get; set; }
        public bool? SpecialAgahi { get; set; }

        //Internal


        public int KindTotalPriceID { get; set; }
        public decimal TotalPrice { get; set; }
        public int NumberMonthlyInstallment { get; set; }
        public int MonthlyInstallment { get; set; }

        //BrandName => BrandID 
        public int BrandID { get; set; }
        public int CarFunction { get; set; }
        public int Year { get; set; }

        //Person => AdvertiseTypeID
        public int AdvertiseTypeID { get; set; }

        //KindCondition => KindConditionID
        public int KindConditionID { get; set; }
        //KindChassis => KindChassisID
        public int KindChassisID { get; set; }
        //KindDiff => KindDiffID
        public int KindDiffID { get; set; }
        //KindColorOut => KindColorOutID
        public int KindColorOutID { get; set; }

        //KindColorIn => KindColorInID
        public int KindColorInID { get; set; }

        //KindModelTip => KindModelTipID
        public int KindModelTipID { get; set; }

        // int => bool
        public bool KindGearbox { get; set; }

        //KindFuel => KindFuelID
        public int KindFuelID { get; set; }
        //KindCrash => KindCrashID
        public int KindCrashID { get; set; }

        //KindPelak => KindPelakID
        public int KindPelakID { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasSound { get; set; }



    }

}