
namespace Exampl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            playerMove.Stream = Properties.Resources.bus;
            playerAtent.Stream = Properties.Resources.atention;
            MessageBox.Show("Vasya");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playerMove.Play();
            timer1.Start();
        }

        private int stop = 0;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            
            if (progressBar1.Value%10==0)
            {
                timer1.Stop();
                timer2.Start();
                playerMove.Stop();
                SoundDooR();
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Stop();

            }
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            stop++;
            label1.Text=stop.ToString();
            if (stop % 15 == 0)
            {
                timer2.Stop();
                timer1.Start();
                playerAtent.Play();
                Thread.Sleep(3500);
                SoundDooR();
                Thread.Sleep(3500);
                playerMove.Play();
            }
        }

        private void SoundDooR()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.door;
            player.Play();  

        }

        System.Media.SoundPlayer playerMove = new System.Media.SoundPlayer();
        System.Media.SoundPlayer playerAtent = new System.Media.SoundPlayer();

      
    }
}