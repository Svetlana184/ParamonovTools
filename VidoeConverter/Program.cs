using VidoeConverter.facade;
using VidoeConverter.models;

VideoFile video = new VideoFile("video/new_video.mp4", "mp4");
VideoConverterFacade facade = new VideoConverterFacade();
string result = facade.Converter(video);
Console.WriteLine(result);
