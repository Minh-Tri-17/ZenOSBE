using ZenOS.BLL.Interfaces;
using ZenOS.DAL.Models;
using ZenOS.MB;
using ZenOS.Util;

namespace ZenOS.BLL.Services
{
    public class DashboardService
    {
        #region Infrastructure

        private readonly ZenOsContext _context; // Dùng để truy cập vào DbContext
        private readonly ICurrentUserService _currentUser; // Dùng để lấy thông tin người dùng hiện tại

        public DashboardService(ZenOsContext context, ICurrentUserService currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        #endregion

        #region Default Operations

        #endregion

        #region Custom Operations

        #region Statistics

        public async Task<APIResults<decimal>> GetStatisticsProfit()
        {
            return APIResults<decimal>.Success(12628, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<decimal>> GetStatisticsRevenue()
        {
            return APIResults<decimal>.Success(14679, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<decimal>> GetStatisticsSpending()
        {
            return APIResults<decimal>.Success(56575, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<int>> GetStatisticsCustomer()
        {
            return APIResults<int>.Success(246, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<List<string>>> GetStatisticsService()
        {
            var listService = new List<string>
            {
                "1. massage thái - 1,200 khách/tháng",
                "2. chăm sóc da mặt - 950 khách/tháng",
                "3. gội đầu dưỡng sinh - 1,500 khách/tháng",
                "4. tẩy tế bào chết - 780 khách/tháng",
                "5. massage đá nóng - 890 khách/tháng",
                "6. xông hơi thảo dược - 1,100 khách/tháng",
                "7. trị liệu giảm đau vai gáy - 970 khách/tháng",
                "8. chăm sóc móng tay & chân - 860 khách/tháng",
                "9. nâng cơ trẻ hóa da - 720 khách/tháng",
                "10. massage bấm huyệt - 1,050 khách/tháng",
            };

            return APIResults<List<string>>.Success(listService, Messages.GetListResultSuccess);
        }

        #endregion

        #region Chart

        public async Task<APIResults<DataChartNumericModel>> GetChartColumn()
        {
            var dataChart = new DataChartNumericModel
            {
                Values = new List<NumericSeriesModel>
                {
                    new NumericSeriesModel {
                        Name  = "Net Profit",
                        Data  = new int [] { 44, 55, 57, 56, 61, 58, 63, 60, 66 }
                    },
                    new NumericSeriesModel {
                        Name = "Revenue",
                        Data = new int [] { 76, 85, 101, 98, 87, 105, 91, 114, 94 }
                    },
                    new NumericSeriesModel {
                        Name = "Free Cash Flow",
                        Data = new int[] { 35, 41, 36, 26, 45, 48, 52, 53, 41 }
                    },
                },
                Labels = new string[] { "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" }
            };

            return APIResults<DataChartNumericModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<DataChartSingleModel>> GetChartDonut()
        {
            var dataChart = new DataChartSingleModel
            {
                Values = new int[] { 44, 55, 41, 17, 15 },
                Labels = new string[] { "series-1", "series-2", "series-3", "series-4", "series-5" }
            };

            return APIResults<DataChartSingleModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<DataChartSingleModel>> GetChartFunnel()
        {
            var dataChart = new DataChartSingleModel
            {
                Values = new int[] { 200, 330, 548, 740, 880, 990, 1100, 1380 },
                Labels = new string[] { "Sweets", "Processed Foods", "Healthy Fats", "Meat", "Beans & Legumes", "Dairy", "Fruits & Vegetables", "Grains" }
            };

            return APIResults<DataChartSingleModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<DataChartSingleModel>> GetChartLine()
        {
            var dataChart = new DataChartSingleModel
            {
                Values = new int[] { 10, 41, 35, 51, 49, 62, 69, 91, 148 },
                Labels = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep" }
            };

            return APIResults<DataChartSingleModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<DataChartNumericModel>> GetChartRadar()
        {
            var dataChart = new DataChartNumericModel
            {
                Values = new List<NumericSeriesModel>
                {
                    new NumericSeriesModel
                    {
                        Name  = "Series-1",
                        Data  = new int [] { 80, 50, 30, 40, 100, 20 }
                    },
                    new NumericSeriesModel
                    {
                        Name  = "Series-2",
                        Data  = new int [] { 20, 30, 40, 80, 20, 80 }
                    },
                    new NumericSeriesModel
                    {
                        Name  = "Series-3",
                        Data  = new int[] { 44, 76, 78, 13, 43, 10 }
                    },
                },
                Labels = new string[] { "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct" }
            };

            return APIResults<DataChartNumericModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<DataChartXYModel>> GetChartSlope()
        {
            var dataChart = new DataChartXYModel
            {
                Values = new List<XYSeriesModel>
                {
                    new XYSeriesModel{
                        Name  = "Blue",
                        Data = new List<XYPointModel>
                        {
                            new XYPointModel {X = "Category 1", Y = 503},
                            new XYPointModel {X = "Category 2", Y = 580},
                            new XYPointModel {X = "Category 3", Y = 135},
                            new XYPointModel {X = "Category 4", Y = 363},
                        }
                    },
                    new XYSeriesModel{
                        Name  = "Green",
                        Data = new List<XYPointModel>
                        {
                            new XYPointModel {X = "Category 1", Y = 733},
                            new XYPointModel {X = "Category 2", Y = 385},
                            new XYPointModel {X = "Category 3", Y = 715},
                            new XYPointModel {X = "Category 4", Y = 952},
                        }
                    },
                    new XYSeriesModel{
                        Name  = "Orange",
                        Data = new List<XYPointModel>
                        {
                            new XYPointModel {X = "Category 1", Y = 255},
                            new XYPointModel {X = "Category 2", Y = 211},
                            new XYPointModel {X = "Category 3", Y = 441},
                            new XYPointModel {X = "Category 4", Y = 642},
                        }
                    },
                    new XYSeriesModel{
                        Name  = "Red",
                        Data = new List<XYPointModel>
                        {
                            new XYPointModel {X = "Category 1", Y = 428},
                            new XYPointModel {X = "Category 2", Y = 749},
                            new XYPointModel {X = "Category 3", Y = 559},
                            new XYPointModel {X = "Category 4", Y = 748},
                        }
                    },
                },
                Labels = new string[] { }
            };

            return APIResults<DataChartXYModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        public async Task<APIResults<DataChartTreeModel>> GetChartTree()
        {
            var dataChart = new DataChartTreeModel
            {
                Id = "Lucas_Alex",
                Data = new NodeData
                {
                    Name = "Lucas Alex",
                    ImageURL = "https://i.pravatar.cc/300?img=68",
                    BorderColor = "#94ddff"
                },
                Children = new List<DataChartTreeModel>
                {
                    new DataChartTreeModel
                    {
                        Id = "Alex_Lee",
                        Data = new NodeData
                        {
                            Name = "Alex Lee",
                            ImageURL = "https://i.pravatar.cc/300?img=69",
                            BorderColor = "#ffc7c2"
                        },
                        Children = new List<DataChartTreeModel>
                        {
                            new DataChartTreeModel
                            {
                                Id = "Mia_Patel",
                                Data = new NodeData { Name = "Mia Patel", ImageURL = "https://i.pravatar.cc/300?img=49", BorderColor = "#e3c2ff" }
                            },
                            new DataChartTreeModel
                            {
                                Id = "Ryan_Clark",
                                Data = new NodeData { Name = "Ryan Clark", ImageURL = "https://i.pravatar.cc/300?img=13", BorderColor = "#e3c2ff" }
                            },
                            new DataChartTreeModel
                            {
                                Id = "Zoe_Wang",
                                Data = new NodeData { Name = "Zoe Wang", ImageURL = "https://i.pravatar.cc/300?img=54", BorderColor = "#e3c2ff" }
                            }
                        }
                    },
                    new DataChartTreeModel
                    {
                        Id = "Leo_Kim",
                        Data = new NodeData
                        {
                            Name = "Leo Kim",
                            ImageURL = "https://i.pravatar.cc/300?img=43",
                            BorderColor = "#ffc7c2"
                        },
                        Children = new List<DataChartTreeModel>
                        {
                            new DataChartTreeModel
                            {
                                Id = "Ava_Jones",
                                Data = new NodeData { Name = "Ava Jones", ImageURL = "https://i.pravatar.cc/300?img=51", BorderColor = "#d2edc5" }
                            },
                            new DataChartTreeModel
                            {
                                Id = "Maya_Gupta",
                                Data = new NodeData { Name = "Maya Gupta", ImageURL = "https://i.pravatar.cc/300?img=45", BorderColor = "#d2edc5" }
                            }
                        }
                    },
                    new DataChartTreeModel
                    {
                        Id = "Max_Ruiz",
                        Data = new NodeData
                        {
                            Name = "Max Ruiz",
                            ImageURL = "https://i.pravatar.cc/300?img=50",
                            BorderColor = "#ffc7c2"
                        }
                    }
                }
            };

            return APIResults<DataChartTreeModel>.Success(dataChart, Messages.GetListResultSuccess);
        }

        #endregion

        #endregion
    }
}
