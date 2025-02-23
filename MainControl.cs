using OxyPlot;
using System.Data;
using OxyPlot.Series;
using OxyPlot.Axes;
using BookSalesSystem2._0.OrderFolder;

namespace BookSalesSystem2._0
{
    public partial class MainControl : UserControl
    {
        private OrderService orderService = new OrderService();
        private List<Order> orders = new List<Order>();

        public MainControl()
        {
            InitializeComponent();
            InitializeData();
        }

        private async void InitializeData()
        {
            orders = await orderService.GetOrdersAsync();

            InitializeBooksCharts();
            InitializeFinanceCharts();
        }

        private void InitializeFinanceCharts()
        {
            var financialData = orders
                .GroupBy(o => o.OrderDate.Date)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalSales = g.Sum(o => o.Books.Sum(b => b.Quantity * b.Price))
                })
                .ToList();

            var financialPlotModel = new PlotModel { Title = "Фінанси" };
            financialPlotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "dd/MM/yyyy",
                Title = "Дата",
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IsZoomEnabled = true,
                IsPanEnabled = true
            });

            financialPlotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Сума продажів",
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                IsZoomEnabled = true,
                IsPanEnabled = true
            });

            var financialSeries = new OxyPlot.Series.LineSeries
            {
                Title = "Сума продажів",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White,
                StrokeThickness = 3,
                Color = OxyColors.SkyBlue
            };

            foreach (var item in financialData)
            {
                financialSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(item.Date), (double)item.TotalSales));
            }

            financialPlotModel.Series.Add(financialSeries);
            plotView2.Model = financialPlotModel;
        }

        private void InitializeBooksCharts()
        {
            var quantitySoldData = orders
                .SelectMany(o => o.Books)
                .GroupBy(b => b.Title)
                .Select(g => new
                {
                    BookTitle = g.Key,
                    QuantitySold = g.Sum(b => b.Quantity)
                })
                .OrderByDescending(g => g.QuantitySold)
                .ToList();

            var quantitySoldPlotModel = new PlotModel { Title = "Кількість проданих книг" };
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Angle = -45
            };

            foreach (var item in quantitySoldData)
            {
                string shortTitle = item.BookTitle.Length > 15 ? item.BookTitle.Substring(0, 12) + "..." : item.BookTitle;
                categoryAxis.Labels.Add(shortTitle);
            }

            var valueAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "Кількість проданих книг" };

            var quantitySoldSeries = new OxyPlot.Series.BarSeries
            {
                Title = "Кількість проданих книг",
                StrokeThickness = 1,
                LabelPlacement = LabelPlacement.Inside,
                TrackerFormatString = "{0}\nНазва: {1}\nПродано: {2} шт."
            };

            foreach (var item in quantitySoldData)
            {
                quantitySoldSeries.Items.Add(new BarItem { Value = item.QuantitySold });
            }

            quantitySoldPlotModel.Axes.Add(categoryAxis);
            quantitySoldPlotModel.Axes.Add(valueAxis);
            quantitySoldPlotModel.Series.Add(quantitySoldSeries);

            plotView1.Model = quantitySoldPlotModel;
        }
    }
}
