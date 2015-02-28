using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;


namespace MarioSounds
{
    class Sounds
    {
        static void Main(string[] args)
        {
            // if you want to listen the sounds (press a key after every each of them to listen the next sound) :)

            //Music:
            GameOverSound();
            MarioDiesSound();
            RunningOutOfTime(); //if we have time limit
            LevelComplete(); //level complete or winning the game

            //Short Sounds:
            Jump();
            Kick();
            BreakBlock();
            Bump();
            GetCoin(); //get coin or something that gives scores
            EnemyFalls();
            EnemyFire();
            FireBall();
            FireWorks();
            FlagPole();
            Pause();
            PowerUp();
            Pipe();
        }

        static void GameOverSound()
        {
            string path = @"..\..\GameOver.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey(); //to keep program running and music playing until a key is pressed
        }

        static void MarioDiesSound()
        {
            string path = @"..\..\MarioDies.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void RunningOutOfTime()
        {
            string path = @"..\..\RunningOutOfTime.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void LevelComplete()
        {
            string path = @"..\..\LevelComplete.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void BreakBlock()
        {
            string path = @"..\..\BreakBlock.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void Bump()
        {
            string path = @"..\..\Bump.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void GetCoin()
        {
            string path = @"..\..\Coin.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void EnemyFalls()
        {
            string path = @"..\..\EnemyFalls.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void EnemyFire()
        {
            string path = @"..\..\EnemyFire.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void FireBall()
        {
            string path = @"..\..\FireBall.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void FireWorks()
        {
            string path = @"..\..\FireWorks.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void FlagPole()
        {
            string path = @"..\..\FlagPole.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void Jump()
        {
            string path = @"..\..\Jump.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void Kick()
        {
            string path = @"..\..\Kick.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void Pause()
        {
            string path = @"..\..\Pause.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void Pipe()
        {
            string path = @"..\..\Pipe.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

        static void PowerUp()
        {
            string path = @"..\..\PowerUp.wav";
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = path;
            player.Load();

            if (player.IsLoadCompleted)
            {
                player.Play();
            }
            Console.ReadKey();
        }

    }
}
