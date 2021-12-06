﻿using System;
using System.Collections.Generic;


namespace WorkTestApp
{
    public static class FirstApp
    {
        public static int SumMod(List<int> numbers)
        {
            int sum = 0;
            int count = 0;            
            foreach (var number in numbers)
            { if (number % 2 != 0)
                {
                    count++;
                    if (count % 2 == 0) sum += number;
                }
            }
            return Math.Abs(sum);
        }
    }
}
