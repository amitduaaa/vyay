namespace Dvinci.VYAY.Backend.Api.Apis;

public class HealthApi : IApi
{
    public void Register(IEndpointRouteBuilder app)
    {
        app.MapGet("/api/health", GetHealthService);
    }

    internal IResult GetHealthService()
    {
        return Results.Ok("Health service is running");
    }
}
