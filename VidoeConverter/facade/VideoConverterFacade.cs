using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidoeConverter.models;
using VidoeConverter.services;

namespace VidoeConverter.facade
{
    public class VideoConverterFacade
    {
        private readonly VideoValidation _validator;
        private readonly VideoMetadataReader _metadataReader;
        private readonly VideoProcessingEngine _processingEngine;

        public VideoConverterFacade()
        {
            _validator = new VideoValidation();
            _metadataReader = new VideoMetadataReader();
            _processingEngine = new VideoProcessingEngine();
        }

        public async Task<string> ConvertVideoAsync(VideoFile video, int targetWidth, int targetHeight, string targetFormat)
        {

            // 2. Валидация файла
            _validator.Validate(video);

            // 3. Чтение метаданных
            await _metadataReader.ReadAsync(video);

            // 4. Транскодирование и изменение размера
            await _processingEngine.ProcessVideoAsync(video, targetWidth, targetHeight, targetFormat);

            return video.OutputPath ?? throw new Exception("Не удалось сохранить файл.");
        }
    }
}