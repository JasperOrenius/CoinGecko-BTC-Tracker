using CoinGecko_BTC_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGecko_BTC_Tracker.ViewModels
{
    public class MainViewModel
    {
        public BaseViewModel CurrentViewModel { get; }

        public MainViewModel()
        {
            ChartInteractionService chartInteractionService = new ChartInteractionService();
            CurrentViewModel = new DataViewModel(chartInteractionService, null);
        }
    }
}