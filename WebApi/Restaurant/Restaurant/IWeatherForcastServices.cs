namespace Restaurant
{
    public interface IWeatherForcastServices
    {
        IEnumerable<WeatherForecast> Get();
        IEnumerable<WeatherForecast> Get(int numberOfResoults, int minTemp, int MaxTemp);
    }
}