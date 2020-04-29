using System;
using System.Threading;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { Title = "MyVideo"};
            var videoEncoder = new VideoEncoder(); //Publisher
            var mailService = new MailService(); //Subscriber
            var messageService = new MessageService(); //Subscriber

            //Need to Subscribe to the Event
            videoEncoder.VideoEncoded += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded += messageService.onVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    public class MessageService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text...." + e.Video.Title);
        }
    }

    public class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending and email..." + e.Video.Title);
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //Step 1: define a delegate
        public delegate void VideoEncodedHandler(object source, VideoEventArgs e);

        //Step 2: Define an event based on that delegate
        public event VideoEncodedHandler VideoEncoded;

        //New dotnet versions included ways to define delates and events in one line as shown below:
        //EventHandler
        //EventHandler<TEventArgs>
        //public event EventHandler<VideoEventArgs> VideoEncoded;
        //This takes the place of steps 1 and 2 above


        public void Encode(Video video)
        {
            Console.WriteLine("Video encoding...");
            Thread.Sleep(3000);
            Console.WriteLine("Done!");
            onVideoEncoded(video);
        }

        protected virtual void onVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }

    public class Video
    {
        public string Title { get; set; }
    }
}
