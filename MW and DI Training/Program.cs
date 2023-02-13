var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//}
//public interface IShowTime
//{
//    string GetTime();
//}
//public class ShortTime : IShowTime
//{
//    public string GetTime()
//    {
//        return DateTime.Now.ToShortTimeString();
//    }
//}
//public class LongTime : IShowTime
//{
//    public string GetTime()
//    {
//        return DateTime.Now.ToLongTimeString();
//    }
//}

app.Run();
