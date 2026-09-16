try
{
    AppLogin login = new AppLogin();
    ILogger logger = login.CreateLogger("info");
    logger.logError();
    logger.logInfo();
    logger.logWarning();

}
catch
{
    Console.WriteLine("");
}


class InfoLogger : ILogger
{
    public void logError()
    {
        Console.WriteLine("неподходящий логгер");
    }

    public void logInfo()
    {
        DateTime date = new DateTime();
        StreamWriter sw = new StreamWriter("D://app.log");
        sw.WriteLine(date.ToLocalTime() + " INFO");
        sw.Close();
        Console.WriteLine("строка записана");
    }

    public void logWarning()
    {
        Console.WriteLine("неподходящий логгер");
    }
}

class WarningLogger : ILogger
{
    public void logError()
    {
        Console.WriteLine("неподходящий логгер");
    }

    public void logInfo()
    {
        Console.WriteLine("неподходящий логгер");
    }

    public void logWarning()
    {
        DateTime date = new DateTime();
        StreamWriter sw = new StreamWriter("D://app.log");
        sw.WriteLine(date.ToLocalTime() + "WARNING");
        sw.Close();
         Console.WriteLine("строка записана");
    }
}

class ErrorLogger : ILogger
{
    public void logError()
    {
        DateTime date = new DateTime();
        StreamWriter sw = new StreamWriter("D://app.log");
        sw.WriteLine(date.ToLocalTime() + "ERROR");
        sw.Close();
        Console.WriteLine("строка записана");
    }

    public void logInfo()
    {
        Console.WriteLine("неподходящий логгер");
    }

    public void logWarning()
    {
        Console.WriteLine("неподходящий логгер");
    }
}

interface ILogger
{
    void logInfo();
    void logWarning();

    void logError();
}
class AppLogin()
{
    private bool hasLogger = false;
    public ILogger CreateLogger(string type)
    {
        if (!hasLogger)
        {
            hasLogger = true;
            switch (type)
            {
                case "info": return new InfoLogger();
                case "warning": return new WarningLogger();
                case "error": return new ErrorLogger();
                default: throw new ArgumentException("нет такого логгера");
            }
        }
        else
        {
            throw new ArgumentException("логгер уже создан");
        }
        
    }
}
