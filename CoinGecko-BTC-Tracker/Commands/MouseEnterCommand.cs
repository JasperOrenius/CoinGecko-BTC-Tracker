using CoinGecko_BTC_Tracker.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoinGecko_BTC_Tracker.Controllers
{
    class MouseEnterCommand : BaseCommand
    {
        private readonly ChartInteractionService chartInteractionService;
        private readonly Canvas chartCanvas;

        public MouseEnterCommand(ChartInteractionService chartInteractionService)
        {
            this.chartInteractionService = chartInteractionService;
            this.chartCanvas = chartCanvas;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is MouseEventArgs e)
            {
                Point mousePosition = e.GetPosition(chartCanvas);
                chartInteractionService.HandleMouseEnter(mousePosition);
            }
        }
    }
}