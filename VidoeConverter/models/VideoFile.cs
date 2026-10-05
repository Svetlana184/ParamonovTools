using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidoeConverter.models
{
    public class VideoFile
    {
        public string FilePath { get; set; }
        public string Format { get; set; }
        public string? OutputPath { get; set; }

        public VideoFile(string filepath, string format)
        {
            FilePath = filepath;
            Format = format;
        }
    }
}