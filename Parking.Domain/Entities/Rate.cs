using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class Rate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double DailyAmount { get; set; }
        public double OverNightAmount { get; set; }
        public double PeriodAmount { get; set; }
    }
}
