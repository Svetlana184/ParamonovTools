using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VidoeConverter.services
{
    public class VideoDecoder
    {
        public void Decode(models.VideoFile video)
        {
            Console.WriteLine($"Декодируем файл формата {video.Format}");
        }
    }
}