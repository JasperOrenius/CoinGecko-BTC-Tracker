﻿using CoinGecko_BTC_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoinGecko_BTC_Tracker.ViewModels
{
    /// <summary>
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : UserControl
    {
        private readonly ChartService chartService;
        public DataView()
        {
            InitializeComponent();
            Loaded += OnLoaded;
            chartService = new ChartService();
        }

        private void DataViewModel_ChartUpdated(object? sender, List<Tuple<DateTime, double>> bitcoinPrices)
        {
            List<Ellipse> dataPoints = new List<Ellipse>();
            List<Point> dataPointPositions = new List<Point>();
            chartService.DrawPriceChart(chartCanvas, bitcoinPrices, dataPoints, dataPointPositions);
            var viewModel = (DataViewModel)DataContext;
            if(viewModel != null)
            {
                viewModel.chartInteractionService.Initialize(chartCanvas, dataPoints, dataPointPositions);
            }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var chartInteractionService = new ChartInteractionService();
            var viewModel = new DataViewModel(chartInteractionService, chartCanvas);
            DataContext = viewModel;
            if(viewModel != null )
            {
                viewModel.ChartUpdated += DataViewModel_ChartUpdated;
            }
        }
    }
}
