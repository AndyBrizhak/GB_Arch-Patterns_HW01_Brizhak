﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Arch_Patterns_HW01_Brizhak
{
    public class IdHelper
    {
        public static long CalculateId()
        {
            long id = DateTime.Now.Ticks;
            return id;
        }
    }
}
