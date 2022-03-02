using BlazorWebApp.Shared;
using BlazorWebApp.Shared.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebApp.Client.Pages
{
    public partial class FetchData
    {
        private List<ColumnDefinition> columnDefinition;
        private List<WeatherForecast> forecasts;


        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<List<WeatherForecast>>("WeatherForecast");
            Initialize();
        }
        private void Initialize()
        {
            if (columnDefinition == null)
            {
                columnDefinition = new List<ColumnDefinition>();
                columnDefinition.AddRange(
                    new ColumnDefinition[]
                    {
                        new ColumnDefinition {DataField = "Date", Caption = "Date"},
                        new ColumnDefinition {DataField = "TemperatureC", Caption = "Temp.(C)"},
                        new ColumnDefinition {DataField = "TemperatureF", Caption = "Temp.(F)"},
                        new ColumnDefinition {DataField = "Summary", Caption = "Summary"}
                    }
               );
            }
        }
    }
}
