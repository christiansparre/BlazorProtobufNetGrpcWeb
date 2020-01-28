using System.ServiceModel;
using System.Threading.Tasks;

namespace BlazorProtobufNetGrpcWeb.Shared
{
    [ServiceContract]
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecasts();
    }
}