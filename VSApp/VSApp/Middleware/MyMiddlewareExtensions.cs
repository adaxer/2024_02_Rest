namespace VSApp.Middleware;

public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app)
    {
        // Initialisieren der eigenen Middleware
        app.UseMiddleware<MyMiddleware>();
        return app;
    }
}
