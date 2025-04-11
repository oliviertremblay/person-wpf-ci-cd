﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_wpf_demo.Utils
{
    public static class StringExtension
    {
        public static bool Empty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool NotEmpty(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
