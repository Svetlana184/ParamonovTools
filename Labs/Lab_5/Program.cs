class GameSettings
{
    private static GameSettings instance;
    private GameSettings()
    {

    }

    public static GameSettings GetInstance()
    {
        if (instance == null)
        {
            instance = new GameSettings();
        }
        return instance;
    }

    public void GetInfo()
    {
        Console.WriteLine("Volume " + Volume);
        Console.WriteLine("Language " + Language);
        Console.WriteLine("Resolution " + Resolution);
        Console.WriteLine("Fullscreen " + Fullscreen);
    }

    public int Volume;
    public string Language;
    public string Resolution;
    public bool Fullscreen
;
}

