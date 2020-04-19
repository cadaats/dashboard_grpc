using DashboardService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Data
{
    public class PieChartData : IChartData
    {
        public IChartModel[] Data { get; set; }

        public PieChartData() => Data = new PieChartModel[] 
        {
            new PieChartModel(){
            ColorByPoint = true,
            Name = "Browsers",
            Data = new PieChartModel.Datum[]
                {
                    new PieChartModel.Datum()
                    {
                        Name= "Chrome",
                        Y = 61.41,
                        Selected = true,
                        Sliced = true
                    },
                    new PieChartModel.Datum()
                    {
                        Name= "Internet Explorer",
                        Y = 11.84
                    },
                    new PieChartModel.Datum()
                    {
                        Name= "Firefox",
                        Y = 10.85
                    },
                    new PieChartModel.Datum()
                    {
                        Name= "Edge",
                        Y = 4.67
                    },
                    new PieChartModel.Datum()
                    {
                        Name= "Opera",
                        Y = 4.18
                    },
                    new PieChartModel.Datum()
                    {
                        Name= "Safari",
                        Y = 1.6
                    },
                    new PieChartModel.Datum()
                    {
                        Name= "Others",
                        Y = 5.45
                    }
                }
            }
        };
    }
}
