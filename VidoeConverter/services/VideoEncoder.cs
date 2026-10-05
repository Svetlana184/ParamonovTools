using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidoeConverter.services
{
    public class VideoEncoder
    {
        public void Encode(models.VideoFile video, string format)
        {
            Console.WriteLine($"Кодируем файл формата {format}");
        }
    }
}