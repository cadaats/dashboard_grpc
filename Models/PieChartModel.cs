using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Models
{
    public class PieChartModel : IChartModel
    {
        public string Name { get; set; }
        public bool ColorByPoint { get; set; }
        public Datum[] Data { get; set; }

        public class Datum
        {
            public string Name { get; set; }
            public double Y { get; set; }

            public bool? Sliced { get; set; }

            public bool? Selected { get; set; }
        }
    }
}
