using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidoeConverter.models;

namespace VidoeConverter.services
{
    public class VideoValidation
    {
        public void Validate(VideoFile video)
        {
            if (string.IsNullOrWhiteSpace(video.FilePath))
                throw new ArgumentException("Путь к файлу не может быть пустым.");

            if (!File.Exists(video.FilePath))
                throw new FileNotFoundException($"Файл не найден по пути: {video.FilePath}");

            Console.WriteLine("Видео успешно прошло проверку существования.");
        }
    }
}