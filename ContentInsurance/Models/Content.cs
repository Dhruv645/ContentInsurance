﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentInsurance.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
