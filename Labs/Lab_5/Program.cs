Console.WriteLine("================================   GAME SETTINGS  ================================");
Console.WriteLine($"1 — Показать настройки \n 2 — Изменить громкость \n 3 — Изменить язык \n 4 — Изменить разрешение \n 5 — Включить/выключить полный экран \n 0 — Выход");
GameSettings settings = GameSettings.GetInstance();
try
{
    int var = int.Parse(Console.ReadLine()!);
    switch (var)
    {
        case 1:
            settings.GetInfo();
            break;
        case 2:
            Console.WriteLine("Введите громкость");
            int volume = int.Parse(Console.ReadLine()!);
            settings.Volume = volume;
            settings.GetInfo();
            break;
        case 3:
            Console.WriteLine("Введите язык");
            string lang = Console.ReadLine()!;
            settings.Language = lang;
            settings.GetInfo();
            break;
        case 5:
            if (settings.Fullscreen)
            {
                settings.Fullscreen = false;
            } else
            {
                settings.Fullscreen = true;
            }
            settings.GetInfo();
            break;
        case 4:
            Console.WriteLine("Введите разрешение");
            string res = Console.ReadLine()!;
            settings.Resolution = res;
            settings.GetInfo();
            break;
        default:
            break;
    }
}
catch
{
    Console.WriteLine("Введите цифру от 0 до 5");
}



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

