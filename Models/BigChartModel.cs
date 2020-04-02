using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Models
{
    public class BigChartModel : IChartModel
    {
        public string Name { get; set; }
        public int[] Data { get; set; }
    }
}
