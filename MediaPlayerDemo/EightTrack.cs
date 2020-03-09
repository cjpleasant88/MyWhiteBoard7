using System;
using System.Collections.Generic;
using System.Text;
using MediaPlayers;

namespace MediaPlayerDemo
{
    class EightTrack : IStreamingDevice
    {
        public string DeviceName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsPlaying { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsPaused { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Ffwd()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public bool Play()
        {
            throw new NotImplementedException();
        }

        public void Rewind()
        {
            throw new NotImplementedException();
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
