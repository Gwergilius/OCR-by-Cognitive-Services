using OCR.Demo.API.Requests;
using OCR.Demo.API.Services;

namespace OCR.Demo.API.RequestHandlers;

public class GetAllForecastsHandler
    : IRequestHandler<GetAllForecatsRequest, IEnumerable<WeatherForecast>>
{
    private readonly IWeatherForecastService _forecastService;

    public GetAllForecastsHandler(IWeatherForecastService forecastService)
    {
        _forecastService = forecastService;
    }

    public async Task<IEnumerable<WeatherForecast>> Handle(
        GetAllForecatsRequest request,
        CancellationToken cancellationToken)
        => await _forecastService.GetWeatherForecast();
}
