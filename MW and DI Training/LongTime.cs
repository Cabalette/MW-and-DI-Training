namespace MW_and_DI_Training
{
    public class LongTime : IShowTime
    {
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
