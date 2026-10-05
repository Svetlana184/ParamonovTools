using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidoeConverter.models;

namespace VidoeConverter.services
{
    public class VideoMetadataReader
    {
        public void Reader(VideoFile video)
        {
            Console.WriteLine($"Получаем информацию с видео: {video.FilePath}");
        }
    }
}