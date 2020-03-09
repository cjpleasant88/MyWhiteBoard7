using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayers
{
    public interface IStreamingDevice
    {
        public string DeviceName { get; set; }
        public bool IsPlaying { get; set; }
        public bool IsPaused { get; set; }

        bool Play();
        void Pause();
        void Ffwd();
        void Rewind();
        bool Stop();
    }

    class MediaPlayers
    {
    }

    public class DVDPlayer : IStreamingDevice
    {
        public DVDPlayer()
        {
            DeviceName = "My DVD Player";
            IsPlaying = false;
            IsPaused = false;
        }

        public string DeviceName
        {
            get;
            set;
        }

        public bool IsPlaying
        {
            get;
            set;
        }

        public bool IsPaused
        {
            get;
            set;
        }
       

        public void Ffwd()
        {
            Console.WriteLine($"\n\tFFwd {DeviceName}");
        }

        public void Pause()
        {
            if (IsPlaying)
            {
                Console.WriteLine($"\n\t{DeviceName} paused");
            }
            else
            {
                Console.WriteLine($"\n\tCan't pause {DeviceName} stopped");
            }
        }

        public bool Play()
        {
            Console.WriteLine($"\n\tPlay {DeviceName}");
            IsPlaying = true;
            IsPaused = false;
            return IsPlaying;
        }

        public void Rewind()
        {
            Console.WriteLine($"\n\tRewind {DeviceName}");
        }

        public bool Stop()
        {
            Console.WriteLine($"\n\tStop {DeviceName}");
            IsPlaying = false;
            return IsPlaying;
        }
    }
}
