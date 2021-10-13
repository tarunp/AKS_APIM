var builder = WebApplication.CreateBuilder(args);
var httpClient = new HttpClient();
var app = builder.Build();
app.MapGet("/", () => "Weather API!");
app.MapGet("/current/{location}", async (string location) => await httpClient.GetStringAsync($"https://wttr.in/{location}?format=4"));
app.MapGet("/moon/{location}", async (string location) => await httpClient.GetStringAsync($"https://wttr.in/{location}?format=Moon day: %M %m Sunset: %s"));
app.Run();
