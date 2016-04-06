using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YoutubeDownloader
{
    public class YouTubeModel
    {

        public IEnumerable<VideoInfo> VideoInfo { get; set; }
        public string FolderPath { get; set; }
        public string Link { get; set; }
        public string FilePath { get; set; }
        public VideoInfo Video { get; set; }
    }
    public class YouTubeVideoModel : YouTubeModel
    {
        public VideoDownloader VideoDownloaderType { get; set; }
    }
    public class YouTubeAudioModel : YouTubeModel
    {
        public AudioDownloader AudioDownloaderType { get; set; }
    }
}
