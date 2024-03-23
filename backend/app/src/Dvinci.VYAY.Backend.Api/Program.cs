using Dvinci.VYAY.Backend.Api.Apis;
using Dvinci.VYAY.Backend.Api.Extensions;
using Dvinci.VYAY.Common.Extensions;
using Dvinci.VYAY.DataAccess;
using Dvinci.VYAY.DomainLogic;

var builder = WebApplication.CreateBuilder(args);

// Set up SwaggerGen
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>{});

// Set up appsettings configuration based on the environment
var basePath = builder.Environment.ContentRootPath;
builder.Configuration
    .SetBasePath(basePath)
    .RegisterAppSettings(builder.Environment.EnvironmentName)
    .AddEnvironmentVariables();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
builder.Services.RegisterConfigs(builder.Configuration);
builder.Services.RegisterApiServices(builder.Configuration);
builder.Services.RegisterDbContext(builder.Configuration);
builder.Services.RegisterDataAcess();
builder.Services.RegisterDomainLogic();

var app = builder.Build();

// Ensure database creation
app.Services.EnsureDatabaseCreated();

foreach (var api in app.Services.GetServices<IApi>())
    api.Register(app);

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c =>
    {
        c.RouteTemplate = "api/swagger/{documentname}/swagger.json";
    });
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/api/swagger/v1/swagger.json", "VYAY Swagger V1");
        c.RoutePrefix = "api/swagger";
    });
}

app.Run();
