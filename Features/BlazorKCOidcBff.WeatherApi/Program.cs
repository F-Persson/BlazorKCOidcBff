using BlazorKCOidcBff.ApiService;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

builder.Services.AddAuthentication()
    .AddJwtBearer("Bearer", jwtOptions =>
{
    // Your authority (keycloak realm)
    jwtOptions.Authority = "https://keycloak/realms/WeatherShop/";

    // Your audience (scope in keycloak)
    jwtOptions.Audience = "weather.api";

});
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapDefaultEndpoints();

app.MapWeatherApi();

app.Run();

