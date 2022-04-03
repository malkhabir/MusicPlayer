namespace MusicPlayer
{
    public partial class MediaToPlay : Form
    {
        MusicPlayer media = new MusicPlayer();
        OpenFileDialog od = new OpenFileDialog();
        

        public MediaToPlay()
        {
            InitializeComponent();
            
            //Volume Params
            volumeLevel.Maximum = 1000;
            volumeLevel.Minimum = 0;
            volumeLevel.TickFrequency = 100;
            volumeLevel.Value = 4;
            volumeTxtBox.Text = volumeLevel.Value.ToString();


        }

        private void openIt_Click(object sender, EventArgs e) //File dialog button event handler
        {


            if (od.ShowDialog() == DialogResult.OK)
            {
                media.open(od.FileName);
                media.setVolume(volumeLevel.Value.ToString());

            }

            // Convert from milliseconds to minutes 60,000 then output the value in soundLength textbox.
            soundLength.Text = (float.Parse(media.getLength())/60000).ToString();


            // Timer
            timer1.Start();

            //Progress bar Params
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;


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

        private void timer1_Tick(object sender, EventArgs e)
        {
            positionofmusic.Text = ((float.Parse(media.getPosition())/float.Parse(media.getLength()))*100).ToString();
            progressBar.Value = (int)(float.Parse(media.getPosition()) / float.Parse(media.getLength()) * 100);
        }
    }
}