﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_MVCApp.Models
{
    public class PagerModel
    {
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public int TotalPage { get; set; }

        public int CurrentPage { get; set; }

        public int LastPage { get; set; }
    }
}