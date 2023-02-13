var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IShowTime, ShortTime>();
builder.Services.AddTransient<IShowTime, LongTime>();

var app = builder.Build();

app.UseMiddleware<ShowTimeMiddleware>();

app.Run();

public class ShowTimeMiddleware
{
    private readonly RequestDelegate request;

    public ShowTimeMiddleware(RequestDelegate request)
    {
        this.request = request;
    }
    public async Task InvokeAsync(HttpContext context, IEnumerable<IShowTime> showTime)
    {
        context.Response.ContentType = "text/html;charset=utf-8";
        if (context.Request.Path == "/short")
        {
            await context.Response.WriteAsync($"<h1>Time: {showTime.First(q => q.GetType() == typeof(ShortTime)).GetTime()}</h1>");
        }
        else await context.Response.WriteAsync($"<h1>Time: {showTime.First(q => q.GetType() == typeof(LongTime)).GetTime()}</h1>");
    }
}
public interface IShowTime
{
    string GetTime();
}
public class ShortTime : IShowTime
{
    public string GetTime()
    {
        return DateTime.Now.ToShortTimeString();
    }
}
public class LongTime : IShowTime
{
    public string GetTime()
    {
        return DateTime.Now.ToLongTimeString();
    }
}
