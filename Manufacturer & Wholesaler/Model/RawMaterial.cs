﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manufacturer___Wholesaler.Model
{
    public class RawMaterial
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Supplier { get; set; }
        public double Cost { get; set; }
        public double Quantity { get; set; }
        public string? Unit { get; set; } // "kg" or "L"
        public DateTime DeliveryDate { get; set; } // Added DateTime for delivery date
    }
}
