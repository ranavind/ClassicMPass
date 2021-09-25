using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApolloTiers.Data;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;

namespace ApolloTiers.Pages
{
   public class FetechDataBase :ComponentBase
    {
        [Inject] WeatherForecastService forecastService { get; set; }
        public WeatherForecast[] forecasts { get; set; }

        protected override  async Task OnInitializedAsync()
        {
             forecasts = await forecastService.GetForecastAsync(new DateTime().Date);
        }
   }
}
    