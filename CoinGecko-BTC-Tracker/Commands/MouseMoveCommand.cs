using CoinGecko_BTC_Tracker.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoinGecko_BTC_Tracker.Controllers
{
    public class MouseMoveCommand : BaseCommand
    {
        private readonly ChartInteractionService chartInteractionService;
        private readonly Canvas chartCanvas;

        public MouseMoveCommand(ChartInteractionService chartInteractionService, Canvas chartCanvas)
        {
            this.chartInteractionService = chartInteractionService;
            this.chartCanvas = chartCanvas;
        }

        public override void Execute(object? parameter)
        {
            if(parameter is MouseEventArgs e)
            {
                Point mousePosition = e.GetPosition(chartCanvas);
                chartInteractionService.HandleMouseMove(mousePosition);
            }
        }
    }
}
