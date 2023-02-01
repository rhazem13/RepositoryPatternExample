using RepositoryPatternExample.Data;

namespace RepositoryPatternExample.Services.WeatherForecastService
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly DataContext context;

        public WeatherForecastService(DataContext context)
        {
            this.context = context;
        }
        public IEnumerable<WeatherForecast> Get()
        {
            return context.Forecasts.ToArray();
        }
    }
}
