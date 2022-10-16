﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Utilities
{
    public class PagedResult<T> where T : class
    {
        public PagedResult()
        {

        }

        public List<T> Data { get; set; }
        public int TotalItems { get; set; }
        public int PagedNumber { get; set; }
        public int PageSize { get; set; }
    }
}
