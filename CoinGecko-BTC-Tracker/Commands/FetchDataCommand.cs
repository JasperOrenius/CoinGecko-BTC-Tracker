using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinGecko_BTC_Tracker.Controllers
{
    public class FetchDataCommand : BaseCommand
    {
        private readonly Func<Task> fetchDataAction;

        public FetchDataCommand(Func<Task> fetchDataAction)
        {
            this.fetchDataAction = fetchDataAction;
        }

        public override async void Execute(object? parameter)
        {
            if(fetchDataAction != null)
            {
                await fetchDataAction();
            }
        }
    }
}
