using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using VidoeConverter.models;

namespace VidoeConverter.services
{
    public class VideoResize
    {
        public void Resizer(VideoFile video, int width, int height)
        {
            Console.WriteLine($"Изменяем разрешение на {width}x{height}");
        }
    }
}