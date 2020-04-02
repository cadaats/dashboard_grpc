using DashboardService.Models;

namespace DashboardService.Data
{
    public interface IChartData
    {
        public IChartModel[] Data { get; set; }
    }
}