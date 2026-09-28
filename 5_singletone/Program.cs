using System;

class Settings
{
    private static Settings instance;
    private Settings()
    {

    }

    public static Settings GetInstance()
    {
        if (instance == null)
        {
            instance = new Settings();
        }
        return instance;
    }

    public int Volime;
}

class Programm
{
    static void Main()
    {
        Settings settings1 = Settings.GetInstance();
        Settings settings2 = Settings.GetInstance();

        settings1.Volime = 80;

        Console.WriteLine(settings1.Volime);
    }
}
