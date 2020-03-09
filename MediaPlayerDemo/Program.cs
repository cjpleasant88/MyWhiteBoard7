using System;
using MediaPlayers;

namespace MediaPlayerDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\tMedia Player Interface Demo!");

            var mediaPlayer = new DVDPlayer();
            //mediaPlayer.DeviceName = "My DVD Player";

            Console.WriteLine($"\tstreaming from: {mediaPlayer.DeviceName}");

            while (true)
            {
                Console.WriteLine("\n\tPush 'Up Arrow' to Play");
                Console.WriteLine("\tPush '[Space Bar]' to Pause");
                Console.WriteLine("\tPush 'F' to Ffwd");
                Console.WriteLine("\tPush 'R' to Rewind");
                Console.WriteLine("\tPush 'S' to Stop");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        mediaPlayer.Play();
                        break;
                    case ConsoleKey.Spacebar:
                        mediaPlayer.Pause();
                        break;
                    case ConsoleKey.F:
                        mediaPlayer.Ffwd();
                        break;
                    case ConsoleKey.R:
                        mediaPlayer.Rewind();
                        break;
                    case ConsoleKey.S:
                        mediaPlayer.Stop();
                        break;

                }
            }
        }
    }
}
