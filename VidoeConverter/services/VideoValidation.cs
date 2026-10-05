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
            {
                throw new ArgumentException("путь неверный");
            }
            Console.WriteLine("Видео прошло проверку");

        }
    }
}