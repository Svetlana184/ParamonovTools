using System;

interface IButton
{
    void Render();
}

interface ITextBox
{
    void Render();
}

class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Кнопка Windows");
    }
}

class WindowsTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Отображаем поле ввода Win");
    }
}
class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Кнопка MacOS");
    }
}
class MacTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Отображаем поле ввода MacOS");
    }
}

interface IGuiFactory
{
    IButton CreateButton();

    ITextBox CreateTextBox();
}

class WindowsFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ITextBox CreateTextBox()
    {
        return new WindowsTextBox();
    }
}

class MacFactory : IGuiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ITextBox CreateTextBox()
    {
        return new MacTextBox();
    }
}

class Program
{
    static void Main()
    {
        string system = "Windows";

        IGuiFactory factory;

        if (system == "Windows")
        {
            factory = new WindowsFactory();
        }
        else
        {
            factory = new MacFactory();
        }
        IButton button = factory.CreateButton();
        ITextBox textBox = factory.CreateTextBox();

        button.Render();
        textBox.Render();
    }
}


