using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidoeConverter.models;

namespace VidoeConverter.services
{
    public class VideoStorage
    {
        public string Save(VideoFile video)
        {
            string outputPath = "video/video.mp4";
            Console.WriteLine($"Сохраняем видео {outputPath}");
            return outputPath;
        }
    }
}