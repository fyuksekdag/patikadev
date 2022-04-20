public class SmsLogger : ILogger
{
    public void writeLog()
    {
        //throw new NotImplementedException();
        Console.WriteLine("SMS olarak log yazar.");
    }
}