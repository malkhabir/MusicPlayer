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
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, IntPtr hwndCallback);

        private StringBuilder returnData;
        private long error;

        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias music";
            mciSendString(command, null, 0, IntPtr.Zero);
           
        }

        public void play()
        {
            string command = "play music";
            mciSendString(command, null, 0, IntPtr.Zero);

        }

        public void pause()
        {
            string command = "pause music";
            mciSendString(command, null, 0, IntPtr.Zero);

        }

        public void stop()
        {
            string command = "stop music";
            mciSendString(command, null, 0, IntPtr.Zero);

            command = "close music";
            mciSendString(command, null, 0, IntPtr.Zero); 

        }

        public void setVolume(string volume)
        {   
            string command = "setaudio music volume to " + volume;
            mciSendString(command, null, 0, IntPtr.Zero);
        }
        
        public int getPosition()
        {
            
            string command = "status music position";
            error = mciSendString(command, returnData, returnData.Capacity, IntPtr.Zero);

            return int.Parse(returnData.ToString());
        }

    }
}
