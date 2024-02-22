
namespace VSApp.Middleware;

public class MyMiddleware
{
    private readonly RequestDelegate next;
    private readonly ILogger<MyMiddleware> logger;

    public MyMiddleware(RequestDelegate next, ILogger<MyMiddleware> logger)
    {
        this.next = next;
        this.logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        logger.LogInformation("In MyMiddleware");
        // Sorgfältig!

        await next(context);
        logger.LogInformation($"Response status: {context.Response.StatusCode}");
    }
}