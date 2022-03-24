namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        MusicPlayer media = new MusicPlayer();
        OpenFileDialog od = new OpenFileDialog();
        ProgressBar progressBar1 = new ProgressBar();
        TrackBar myVolumeTrackbar = new TrackBar();



        public Form1()
        {
            InitializeComponent();
            myVolumeTrackbar.Maximum = 1000;
            myVolumeTrackbar.Minimum = 0;
            myVolumeTrackbar.TickFrequency = 10;
        }

        private void openIt_Click(object sender, EventArgs e)
        {


            if (od.ShowDialog() == DialogResult.OK)
            {
                media.open(od.FileName);

            }


        }

        private void playIt_Click(object sender, EventArgs e)
        {
            nameOf.Text = "Playing" + System.IO.Path.GetFileName(od.FileName);
            media.play();
        }

        private void stopIt_Click(object sender, EventArgs e)
        {
            media.stop();
            nameOf.Text = "";
        }

        private void pauseIt_Click(object sender, EventArgs e)
        {
            media.pause();
            nameOf.Text = System.IO.Path.GetFileName(od.FileName) + "Paused";
        }

        private void volumeLevel_Scroll(object sender, EventArgs e)
        {
            
            media.setVolume(volumeLevel.Value.ToString());
            volumeTxtBox.Text = volumeLevel.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}