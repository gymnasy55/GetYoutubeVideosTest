using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace GetYoutubeVideos
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            var youtube = new YoutubeClient();
            var k = await youtube.Search.GetVideosAsync("gachi");
            foreach (var video1 in k)
            {
                Console.WriteLine($"{video1.Title} | {video1.Author} | {video1.Duration}");
            }

            /*var streamManifest =
                await youtube.Videos.Streams.GetManifestAsync("https://www.youtube.com/watch?v=Fbdq9WCkKiA");
            var streamInfo = streamManifest.GetMuxed().WithHighestVideoQuality();
            if (streamInfo != null)
            {
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                await youtube.Videos.Streams.DownloadAsync(streamInfo, "video.mp4");
            }*/
        }
    }
}