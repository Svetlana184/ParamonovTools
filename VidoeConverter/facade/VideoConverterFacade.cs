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
        private readonly VideoValidation? _validator;
        private readonly VideoMetadataReader? _metadataReader;
        private readonly VideoDecoder? _decoder;
        private readonly VideoResize? _resizer;
        private readonly VideoEncoder? _encoder;
        private readonly VideoStorage? _storage;

        public VideoConverterFacade()
        {
            _validator = new VideoValidation();
            _metadataReader = new VideoMetadataReader();
            _decoder = new VideoDecoder();
            _resizer = new VideoResize();
            _encoder = new VideoEncoder();
            _storage = new VideoStorage();
        }

        public string Converter(VideoFile video)
        {
            _validator?.Validate(video);
            _metadataReader?.Reader(video);
            _decoder?.Decode(video);
            _resizer?.Resizer(video, 1920, 1080);
            _encoder?.Encode(video, "mp4");
            return _storage?.Save(video);
        }

    }
}