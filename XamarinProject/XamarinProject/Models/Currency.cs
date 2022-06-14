﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinProject.Models
{
    public class Currency
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool IsActive { get; set; }
    }
}
