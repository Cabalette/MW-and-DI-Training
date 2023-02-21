namespace MW_and_DI_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<IShowTime, ShortTime>();
            builder.Services.AddTransient<IShowTime, LongTime>();

            var app = builder.Build();

            app.UseMiddleware<ShowTimeMiddleware>();

            app.Run();
        }
    }
}