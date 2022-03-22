using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MusicPlayer
{
    class MusicPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias music";
            mciSendString(command, null, 0, 0);
           
        }

        public void play()
        {
            string command = "play music";
            mciSendString(command, null, 0, 0);

        }

        public void pause()
        {
            string command = "pause music";
            mciSendString(command, null, 0, 0);

        }

        public void stop()
        {
            string command = "stop music";
            mciSendString(command, null, 0, 0);

            command = "close music";
            mciSendString(command, null, 0, 0); 

        }

       
    }
}
