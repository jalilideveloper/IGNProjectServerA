using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iGNProject.Models.Search
{
    public class SearchCarHeavys
    {
        public int CategoryID { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelectID { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }
        public int UntillMonthlyInstallment { get; set; }
        public int FromMonthlyInstallment { get; set; }
        public int UNumberMonthlyInstallment { get; set; }
        public int FNumberMonthlyInstallment { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }
        public int UntillYear { get; set; }
        public int FromYear { get; set; }
   
        public int Kind { get; set; }
        public int UntillCarFunction { get; set; }
        public int FromCarFunction { get; set; }
        public int KindConditionID { get; set; }
        public int KindChassisID { get; set; }
        public int KindDiffID { get; set; }
        public int KindColorOutID { get; set; }
        public int KindColorInID { get; set; }
        public int KindModelTipID { get; set; }
        public bool KindGearbox { get; set; }
        public int KindFuelID { get; set; }
        public int KindCrashID { get; set; }
        public int KindPelakID { get; set; }

        public bool HasSunroof { get; set; }
        public bool HasAlarm { get; set; }
        public bool HasSound { get; set; }


        public int BrandID { get; set; }
    }
}