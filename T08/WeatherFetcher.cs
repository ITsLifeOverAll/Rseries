using System.Text.Json;

namespace T08;

public class WeatherFetcher
{
    public string CurrentWeather { get; }

    public WeatherFetcher()
    {
        var json = File.ReadAllText("weather.json");      // 模擬從 API 取得資料
        var weather = JsonSerializer.Deserialize<WeatherData>(json);
        CurrentWeather = weather?.Status ?? "Unknown";
    }
    
    private class WeatherData
    {
        public string? Status { get; set; }
    }

}

