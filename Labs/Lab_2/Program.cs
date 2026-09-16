Console.WriteLine("Выберите стиль игры: 1 - средневековый, 2 - футуристический");
try
{
    int style = int.Parse(Console.ReadLine()!);
    IGameFactory factory;
    if (style == 1)
    {
        factory = new MedievalFactory();
    }
    else
    {
        factory = new FuturisticFactory();
    }
    IButton button = factory.CreateButton();
    IMenu menu = factory.CreateMenu();
    IWindow window = factory.CreateWindow();

    button.Render();
    menu.Render();
    window.Render();
}
catch
{
    Console.WriteLine("введите число");
}

interface IButton
{
    void Render();
}

interface IWindow
{
    void Render();
}

interface IMenu
{
    void Render();
}

class MedievalButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Создана средневековая кнопка.");
    }
}
class FuturisticButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Создана футуристическая кнопка.");
    }
}

class MedievalWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Создано средневековое окно.");
    }
}

class FuturisticWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Создано футуристическое окно.");
    }
}

class MedievalMenu : IMenu
{
    public void Render()
    {
        Console.WriteLine("Создано средневековое меню.");
    }
}

class FuturisticMenu : IMenu
{
    public void Render()
    {
        Console.WriteLine("Создано футуристическое меню.");
    }
}

interface IGameFactory
{
    IButton CreateButton();

    IWindow CreateWindow();

    IMenu CreateMenu();
}

class MedievalFactory : IGameFactory
{
    public IButton CreateButton()
    {
        return new MedievalButton();
    }

    public IWindow CreateWindow()
    {
        return new MedievalWindow();
    }

    public IMenu CreateMenu()
    {
        return new MedievalMenu();
    }
}

class FuturisticFactory : IGameFactory
{
    public IButton CreateButton()
    {
        return new FuturisticButton();
    }

    public IWindow CreateWindow()
    {
        return new FuturisticWindow();
    }

    public IMenu CreateMenu()
    {
        return new FuturisticMenu();
    }
}