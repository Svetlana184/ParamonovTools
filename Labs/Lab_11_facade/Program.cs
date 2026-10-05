GameFacade gameFacade= new GameFacade();
gameFacade.StartGame();
gameFacade.PauseGame();
gameFacade.ExitGame();
gameFacade.LoadGame();


class GraphicsSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация графики");
    }
    public void Exit()
    {
        Console.WriteLine("Остановка графики");
    }
}

class AudioSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация звука");
    }
    public void Exit()
    {
        Console.WriteLine("Остановка звука");
    }
}
class InputSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация управления");
    }
    public void Exit()
    {
        Console.WriteLine("Остановка управления");
    }
}
class SaveSystem
{
    public void Load()
    {
        Console.WriteLine("Загрузка сохранения");
    }
    public void Exit()
    {
        Console.WriteLine("Сохранение игры");
    }
}

class PlayerSystem
{
    public void Create()
    {
        Console.WriteLine("Создание игрока");
    }
    public void Load()
    {
        Console.WriteLine("Загрузка игрока");
    }
    public void Exit()
    {
        Console.WriteLine("Остановка игрока");
    }
}
class InventorySystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация инвентаря");
    }
    public void Load()
    {
        Console.WriteLine("Загрузка инвентаря");
    }
    public void Exit()
    {
        Console.WriteLine("Сохранение инвентаря");
    }
}
class QuestSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация квестов");
    }
    public void Load()
    {
        Console.WriteLine("Загрузка квестов");
    }
    public void Exit()
    {
        Console.WriteLine("Сохранение квестов");
    }
}
class NetworkSystem
{
    public void Initialize()
    {
        Console.WriteLine("Инициализация сети");
    }
    public void Exit()
    {
        Console.WriteLine("Сохранение сети");
    }
}

class GameFacade
{
    private GraphicsSystem graphics;
    private AudioSystem audio;
    private InputSystem input;
    private SaveSystem save;
    private PlayerSystem player;
    private QuestSystem quests;
    private InventorySystem inventory;
    private NetworkSystem network;
    public GameFacade()
    {
        graphics = new GraphicsSystem();
        audio = new AudioSystem();
        input = new InputSystem();
        save = new SaveSystem();
        player = new PlayerSystem();
        quests = new QuestSystem();
        inventory = new InventorySystem();
        network = new NetworkSystem();
    }
    public void StartGame()
    {
        Console.WriteLine("======================");
        graphics.Initialize();
        audio.Initialize();
        input.Initialize();
        save.Load();
        network.Initialize();
        player.Create();
        inventory.Initialize();
        quests.Initialize();
        Console.WriteLine("Запуск игры");
        Console.WriteLine("======================");
    }
    public void ExitGame()
    {
        Console.WriteLine("======================");
        save.Exit();
        quests.Exit();
        inventory.Exit();
        player.Exit();
        input.Exit();
        audio.Exit();
        graphics.Exit();
        Console.WriteLine("Игра завершена");
        Console.WriteLine("======================");
    }
    public void PauseGame()
    {
        Console.WriteLine("======================");
        player.Exit();
        input.Exit();
        audio.Exit();
        graphics.Exit();
        Console.WriteLine("Игра на паузе");
        Console.WriteLine("======================");
    }
    public void SaveGame()
    {
        Console.WriteLine("======================");
        save.Exit();
        Console.WriteLine("Игра сохранена");
        Console.WriteLine("======================");
    }
    public void LoadGame()
    {
        Console.WriteLine("======================");
        graphics.Initialize();
        audio.Initialize();
        input.Initialize();
        save.Load();
        network.Initialize();
        player.Load();
        inventory.Load();
        quests.Load();
        Console.WriteLine("Игра загружена");
        Console.WriteLine("======================");
    }
}