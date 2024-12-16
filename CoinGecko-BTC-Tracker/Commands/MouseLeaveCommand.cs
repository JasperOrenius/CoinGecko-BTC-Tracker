using CoinGecko_BTC_Tracker.Controllers;
using CoinGecko_BTC_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace CoinGecko_BTC_Tracker.Commands
{
    class MouseLeaveCommand : BaseCommand
    {
        private readonly ChartInteractionService chartInteractionService;

        public MouseLeaveCommand(ChartInteractionService chartInteractionService)
        {
            this.chartInteractionService = chartInteractionService;
        }

        public override void Execute(object? parameter)
        {
            chartInteractionService.HandleMouseLeave();
        }
    }
}
