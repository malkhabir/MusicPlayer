// Author: Mahamad Kanoute (malkhabir)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // This will allow us to create StringBuilder types. StringBuilders are a mutable string data type.
using System.Threading.Tasks;
using System.Runtime.InteropServices; // This allows you to access functions in unmanaged libraries from your managed code.

namespace MusicPlayer
{
    class MusicPlayer
    {
        // Import of the Windows Multimedia API which contains mciSendString() function.
        // The function is written in C++ 
        [DllImport("winmm.dll")]
        

        // Declaration of the method.
        // The mciSendString function is made up of 4 arguments.
        // lpstrCommand defines the command you want the function to execute. Eg: "open device", "play device".
        // lpstrReturnString is a variable that receives the return value of the mciSendString function. *The return value can be null.
        // uReturnLength is the 
        private static extern long mciSendString(string lpstrCommand, StringBuilder? lpstrReturnString, int uReturnLength, IntPtr hwndCallback);
        

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



        public double getLength()
        {
            
            string command = "status music length";
            StringBuilder? musicLen = new StringBuilder(32);

            long error = mciSendString(command, musicLen, musicLen.Capacity, IntPtr.Zero);

            double length = 0;
            double.TryParse(musicLen.ToString(), out length);

            return TimeSpan.FromMilliseconds(length).TotalMinutes;
        }

        public int getLengthInt()
        {

            string command = "status music length";
            StringBuilder? musicLen = new StringBuilder(32);

            long error = mciSendString(command, musicLen, musicLen.Capacity, IntPtr.Zero);

            int length = 0;
            int.TryParse(musicLen.ToString(), out length);

            return length;
        }

        public int getPosition()
        {
            string command = "status music position";
            StringBuilder? musicPos = new StringBuilder(32);

            long error = mciSendString(command, musicPos, musicPos.Capacity, IntPtr.Zero);

            int position = 0;
            int.TryParse(musicPos.ToString(), out position);

            return position;
        }
    }
}
