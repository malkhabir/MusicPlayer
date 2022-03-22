namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        MusicPlayer media = new MusicPlayer();
        OpenFileDialog od = new OpenFileDialog();
        ProgressBar progressBar1 = new ProgressBar();

        public Form1()
        {
            InitializeComponent();
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
            nameOf.Text = "Playing" + od.FileName.Trim;
            media.play();
        }

        private void stopIt_Click(object sender, EventArgs e)
        {
            media.stop();
        }

        private void pauseIt_Click(object sender, EventArgs e)
        {
            media.pause();
            nameOf.Text = od.FileName + "Paused";
        }

        //private void nameofmusic()
        //{
        //    nameOf.Text = "Not working";
        //}


    }
}