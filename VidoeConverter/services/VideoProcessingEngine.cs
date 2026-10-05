using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidoeConverter.models;
using Xabe.FFmpeg;

namespace VidoeConverter.services
{
    public class VideoProcessingEngine
    {
        public async Task ProcessVideoAsync(VideoFile video, int width, int height, string targetFormat)
        {
            string directory = Path.GetDirectoryName(video.FilePath) ?? "";
            string fileName = Path.GetFileNameWithoutExtension(video.FilePath);
            string outputFilePath = Path.Combine(directory, $"{fileName}_{width}x{height}.{targetFormat.ToLower()}");
            
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }

            Console.WriteLine($"Начало обработки. Изменение разрешения на {width}x{height} и конвертация в {targetFormat}...");

            IMediaInfo mediaInfo = await FFmpeg.GetMediaInfo(video.FilePath);
            
            IConversion conversion = FFmpeg.Conversions.New()
                .AddStream(mediaInfo.VideoStreams.First().SetSize(width, height))
                .AddStream(mediaInfo.AudioStreams.First())
                .SetOutput(outputFilePath);

            conversion.OnProgress += (sender, args) =>
            {
                Console.Write($"\rПрогресс конвертации: {args.Percent}%");
            };

            await conversion.Start();
            Console.WriteLine("\nОбработка видео успешно завершена!");

            video.OutputPath = outputFilePath;
        }
    }
}