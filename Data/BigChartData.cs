using DashboardService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Data
{
    public class BigChartData : IChartData
    {
        public IChartModel[] Data { get; set; }
        public BigChartData() => Data = new BigChartModel[]
            {
                new BigChartModel(){Name = "Asia", Data= new int[] { 502, 635, 809, 947, 1402, 3634, 5268 }},
                new BigChartModel(){Name = "Africa", Data= new int[] { 106, 107, 111, 133, 221, 767, 1766 }},
                new BigChartModel(){Name = "Europe", Data= new int[] { 163, 203, 276, 408, 547, 729, 628 }},
                new BigChartModel(){Name = "America", Data= new int[] { 18, 31, 54, 156, 339, 818, 1201 }},
                new BigChartModel(){Name = "Oceania", Data= new int[] { 2, 2, 2, 6, 13, 30, 46 }}
            };
    }
}
