using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsCreator.Models;

namespace CarsCreator.Services
{
    public static class RecountService
    {
        public static int recount(CarSet set)
        {
            int sum = set.priceWithEngine;
            sum += set.diskPrice;
            if (set.sab) sum += 55;
            if (set.signal) sum += 203;
            if (set.carter) sum += 115;
            if (set.sit) sum += 72;
            if (set.xeon) sum += 61;
            if (set.tv) sum += 232;
            if (set.sonar) sum += 90;
            return sum;
        }
    }
}
