﻿using System.Collections.Generic;

namespace eShopSolution.Application.Dtos
{
    public class PageResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}