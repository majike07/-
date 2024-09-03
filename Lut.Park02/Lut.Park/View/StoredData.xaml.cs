using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows;
using LiveCharts.Wpf.Charts.Base;

namespace Lut.Park.View
{
    /// <summary>
    /// StoredData.xaml 的交互逻辑
    /// </summary>
    public partial class StoredData : UserControl
    {
        private Random random = new Random();

        public StoredData()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // 初始化图表，设置轴等
            chart.AxisX.Add(new Axis { Title = "时间" });
            chart.AxisY.Add(new Axis { Title = "数值" });

            // 添加图表系列
            chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "温度",
                    Values = new ChartValues<ObservableValue>()
                },
                new LineSeries
                {
                    Title = "湿度",
                    Values = new ChartValues<ObservableValue>()
                },
                new LineSeries
                {
                    Title = "空气质量",
                    Values = new ChartValues<ObservableValue>()
                }
            };
        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            // 清除旧数据
            foreach (var series in chart.Series)
            {
                series.Values.Clear();
            }

            // 生成并加载新数据
            for (int i = 0; i < 24; i++) // 假设每小时一个数据点
            {
                (chart.Series[0].Values as ChartValues<ObservableValue>).Add(new ObservableValue(random.Next(19, 23))); // 温度，随机值在15到25之间
                (chart.Series[1].Values as ChartValues<ObservableValue>).Add(new ObservableValue(random.Next(30, 35))); // 湿度，随机值在30到70之间
                (chart.Series[2].Values as ChartValues<ObservableValue>).Add(new ObservableValue(random.Next(280, 310))); // 空气质量，随机值在0到100之间
            }

            // 更新图表
            chart.Update(true);
        }
    }
}



