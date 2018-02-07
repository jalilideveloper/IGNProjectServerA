﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iGNProject.Models.Search
{
    public class SearchMotorcycles
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
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
        public int BrandName { get; set; }
        public int Kind { get; set; }
        public int UntillCarFunction { get; set; }
        public int FromCarFunction { get; set; }
        public int KindCondition { get; set; }
        public int KindColorOut { get; set; }
        public int KindModelTip { get; set; }
        public int KindFuel { get; set; }
        public int KindCrash { get; set; }
        public int KindPelak { get; set; }

        public bool HasAlarm { get; set; }

    }
}