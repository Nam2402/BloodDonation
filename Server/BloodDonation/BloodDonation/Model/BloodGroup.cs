﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Model
{
    public class BloodGroup:CRUDDate
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}
