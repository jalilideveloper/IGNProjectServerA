﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iGNProject.Models.Search
{

    public class SearchPersonalEntertainments
    {
        public int Category { get; set; }
        public string SearchInput { get; set; }
        public int ShahrSelect { get; set; }
        public string MahaleSelect { get; set; }
        public bool HasImage { get; set; }
        public bool HasFast { get; set; }



        public int Kind { get; set; }
        public int KindTotalPrice { get; set; }
        public int UntillTotalPrice { get; set; }
        public int FromTotalPrice { get; set; }


    }
}