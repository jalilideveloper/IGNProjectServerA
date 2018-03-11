﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Web;

namespace iGNProject.Models.AdsRegistration
{

    public class RegisterRentHouseSubs
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

        public int KindDepositPrice { get; set; }
        public int DepositPrice { get; set; }
        public int KindRentPrice { get; set; }
        public int RentPrice { get; set; }
        public int Area { get; set; }
        public int RoomNumber { get; set; }
        public int Countryside { get; set; }
        public int AdvertiseTypeID { get; set; }
        public int YearCreated { get; set; }
        public int FloorNumber { get; set; }
        public int KindBottom { get; set; }
        public int KindHeating { get; set; }
        public bool HasParking { get; set; }
        public bool HasElevator { get; set; }
        public bool HasIranianService { get; set; }
        public bool HasForeignService { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasPool { get; set; }
        public bool HasUnderground { get; set; }
        public bool HasYard { get; set; }
        public bool HasSauna { get; set; }
        public bool HasJacuzzi { get; set; }
        public bool HasSleepMaster { get; set; }
        public bool HasRoofGarden { get; set; }
        public bool HasChiller { get; set; }
        public bool HasBarbecue { get; set; }
        public bool HasAltar { get; set; }
        public bool HasLobby { get; set; }
        public bool HasBabyPlayground { get; set; }
        public bool HasGym { get; set; }
    }

}