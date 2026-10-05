using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidoeConverter.models;
using Xabe.FFmpeg;

namespace VidoeConverter.services
{
    public class VideoMetadataReader
    {
        public async Task ReadAsync(VideoFile video)
        {
            IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(video.FilePath);
            
            Console.WriteLine($"Метаданные видео");
            Console.WriteLine($"Длительность: {mediaInfo.Duration}");
            if (mediaInfo.VideoStreams.First() is IVideoStream videoStream)
            {
                Console.WriteLine($"Текущее разрешение: {videoStream.Width}x{videoStream.Height}");
                Console.WriteLine($"Фреймрейт: {videoStream.Framerate} FPS");
            }
        }
    }
}