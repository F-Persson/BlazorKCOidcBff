var builder = DistributedApplication.CreateBuilder(args);

var weatherApi = builder.AddProject<Projects.BlazorKCOidcBff_WeatherApi>("weatherapi");

builder.AddProject<Projects.BlazorKCOidcBff_Server>("blazorfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(weatherApi)
    .WaitFor(weatherApi);

builder.Build().Run();
