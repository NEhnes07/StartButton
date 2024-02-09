using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StartButton
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            CountdownText.ForeColor = Color.White;
            SoundPlayer DingPlayer = new SoundPlayer(Properties.Resources.GentleTone);
            DingPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownText.Text = "2...";
            DingPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            CountdownText.Text = "1...";
            DingPlayer.Play();

            Refresh();
            Thread.Sleep(1000);

            SoundPlayer AirHornPlayer = new SoundPlayer(Properties.Resources.AirHorn);
            AirHornPlayer.Play();
            this.BackColor = Color.Green;
            CountdownText.Text = "GO";
            CountdownText.ForeColor = Color.Black;
            CountdownText.BackColor = Color.Green;

           
        }
    }
}
