namespace MW_and_DI_Training
{
    public class ShortTime : IShowTime
    {
        public string GetTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}
