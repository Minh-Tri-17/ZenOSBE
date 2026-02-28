using ZenOS.MB;

namespace ZenOS.BLL.Interfaces
{
    public interface IDashboardService
    {
        public Task<APIResults<DataChartNumericModel>> GetChartColumn();
        public Task<APIResults<DataChartSingleModel>> GetChartDonut();
        public Task<APIResults<DataChartNumericModel>> GetChartRadar();
        public Task<APIResults<DataChartSingleModel>> GetChartLine();
        public Task<APIResults<DataChartXYModel>> GetChartSlope();
        public Task<APIResults<DataChartSingleModel>> GetChartFunnel();
        public Task<APIResults<DataChartTreeModel>> GetChartTree();
        public Task<APIResults<decimal>> GetStatisticsProfit();
        public Task<APIResults<decimal>> GetStatisticsRevenue();
        public Task<APIResults<decimal>> GetStatisticsSpending();
        public Task<APIResults<int>> GetStatisticsCustomer();
        public Task<APIResults<List<string>>> GetStatisticsService();
    }
}
