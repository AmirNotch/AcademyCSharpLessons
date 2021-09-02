using System;

namespace AcademyCSharpLesson31._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Player play = new Player();

            Play(play, player);

        }

        public static void Play(IPlayable play, IRecodable player)
        {
            play.StartPlay();
            Console.Write('\n');
            play.StopPlay();
            Console.Write('\n');
            play.PauseSound();
            Console.Write('\n');


            player.PauseRecord();
            Console.Write('\n');
            player.StartRecord();
            Console.Write('\n');
            player.StopRecord();
        }
    }

    interface IPlayable
    {
        void StartPlay();
        void StopPlay();
        void PauseSound();
    }

    interface IRecodable
    {
        void StartRecord();
        void StopRecord();
        void PauseRecord();
    }
    class Player : IRecodable, IPlayable
    {
        public void PauseRecord()
        {
            Console.WriteLine("PauseRecord point");
        }

        public void PauseSound()
        {
            Console.WriteLine("PauseSound point");
        }

        public void StartPlay()
        {
            Console.WriteLine("StartPlay point");
        }

        public void StartRecord()
        {
            Console.WriteLine("StartRecord point");
        }

        public void StopPlay()
        {
            Console.WriteLine("StopPlay point");
        }

        public void StopRecord()
        {
            Console.WriteLine("StopRecord point");
        }
    }
}
