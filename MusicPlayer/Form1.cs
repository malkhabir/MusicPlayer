namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        MusicPlayer media = new MusicPlayer();
        OpenFileDialog od = new OpenFileDialog();




        public Form1()
        {
            InitializeComponent();
            //Volume Params
            volumeLevel.Maximum = 1000;
            volumeLevel.Minimum = 0;
            volumeLevel.TickFrequency = 100;
            volumeLevel.Value = 4;
            volumeTxtBox.Text = volumeLevel.Value.ToString();
            //Progress bar Params
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
        }

        private void openIt_Click(object sender, EventArgs e) //File dialog button event handler
        {


            if (od.ShowDialog() == DialogResult.OK)
            {
                media.open(od.FileName);
                media.setVolume(volumeLevel.Value.ToString());

            }


        }

        private void playIt_Click(object sender, EventArgs e) //Event handler for play button
        {
            nameOf.Text = "Playing" + System.IO.Path.GetFileName(od.FileName);
            media.play();
        }

        private void stopIt_Click(object sender, EventArgs e) //Event handler for stop button
        {
            media.stop();
            nameOf.Text = "";
        }

        private void pauseIt_Click(object sender, EventArgs e) //Event handler for pause button
        {
            media.pause();
            nameOf.Text = System.IO.Path.GetFileName(od.FileName) + "Paused";
        }

        private void volumeLevel_Scroll(object sender, EventArgs e) //Event handler for volume scrollbar
        {
            
            media.setVolume(volumeLevel.Value.ToString());
            volumeTxtBox.Text = volumeLevel.Value.ToString();
        }



        private void getCurrentsec() //Gets position
        {
            progressBar.Value = media.getPosition();
        }
    }
}