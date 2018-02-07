﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iGNProject.Models.Search
{
    public class SearchCases
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
        public int MeasureRAM { get; set; }
        public int MeasureCPU { get; set; }
        public int MeasureHard { get; set; }
        public int MeasureGraphic { get; set; }

        public bool HasUSB3 { get; set; }
        public bool HasDVDRW { get; set; }
        public bool HasSpeaker { get; set; }

    }
}