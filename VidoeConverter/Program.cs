using VidoeConverter.facade;
using VidoeConverter.models;

class Program
{
    static async Task Main(string[] args)
    {
        string inputPath = @"C:\Users\User\Videos\sample.mkv"; 
        
        VideoFile video = new VideoFile(inputPath, "mkv");
        VideoConverterFacade facade = new VideoConverterFacade();

        try
        {
            string resultPath = await facade.ConvertVideoAsync(video, 1920, 1080, "mp4");
            
            Console.WriteLine($"\nГотово! Реальный файл сохранен по пути: {resultPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nПроизошла ошибка при конвертации: {ex.Message}");
        }
    }
}
