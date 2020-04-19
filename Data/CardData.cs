using DashboardService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Data
{
    public class CardData : IChartData
    {
        public IChartModel[] Data { get; set; }

        public CardData() => Data = new ChartValue[]
        {
            new ChartValue()
            {
                Value = 71
            },
            new ChartValue()
            {
                Value = 78
            },
            new ChartValue()
            {
                Value = 39
            },
            new ChartValue()
            {
                Value = 36
            }
        };
    }
}
