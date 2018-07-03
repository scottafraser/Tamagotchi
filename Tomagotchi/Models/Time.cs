using System;
namespace Tamagotchi.Models
{
    public class Time
    {

        private int _min;
        private int _sec;
        public static DateTime timer = DateTime.Now;


        public int GetMin()
        {
             _min = int.Parse(timer.ToString("mm"));
            return _min;
        }

        public int GetSec()
        {
            _sec = int.Parse(timer.ToString("ss"));
            return _sec;
        }



    }
}
