using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2_10
{

    class Program
    {
        public abstract class VideoGames
        {
            public string genre;
            public string console;

            public abstract void Gameplay();
            public virtual void Settings()
            {

            }
        }

        public interface Play
        {
            public void Play();
        }

        public interface Quit
        {
            public void Quit();
        }

        public class Tetris : VideoGames, Play, Quit
        {
            public bool inserted;

            public void GamePlay()
            {

            }
            public override void Settings()
            {

            }
            public void Play()
            {

            }

            public void Quit()
            {

            }
        }

        public class Mario : VideoGames, Play, Quit
        {
            public bool inserted;


            public override void Settings()
            {

            }
            public void Play()
            {

            }

            public void Quit()
            {

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
