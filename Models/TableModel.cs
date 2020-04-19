using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Models
{
    public class TableModel : IChartModel
    {
        public long Position { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Symbol { get; set; }
        
        public TableModel()
        {
        }
    }
}
