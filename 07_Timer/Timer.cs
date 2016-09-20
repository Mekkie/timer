using System;

namespace _07_Timer
{
    public class Timer
    {
        internal int Seconds;
        public override string ToString()
        {
            TimeSpan ZeroSeconds = TimeSpan.FromSeconds(Seconds);
            return string.Format("{0:D2}:{1:D2}:{2:D2}",ZeroSeconds.Hours, ZeroSeconds.Minutes, ZeroSeconds.Seconds);
        }
    }
}