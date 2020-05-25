using DashboardService.Data;
using DashboardService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Repositories
{
    public class DataRepository : IDataRepository
    {
        public DataRepository()
        {
        }

        public IChartData GetData(ChartType chartType)
        {
            IChartData chartData = new BigChartData();

            switch (chartType)
            {
                case ChartType.Table:
                    chartData = new Data.TableData();
                    break;
                case ChartType.Pi:
                    break;
                case ChartType.Big:
                    break;
            }
            return chartData;
        }
    }
}
