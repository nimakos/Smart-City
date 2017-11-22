using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(Properties.Resources._131660__bertrof__game_sound_correct );
        System.Media.SoundPlayer startSoundPlayer1 = new System.Media.SoundPlayer(Properties.Resources._241809_suntemple_magic_sfx_for_games);
       
        public main()
        {
            InitializeComponent();
        }

      

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();            

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            startSoundPlayer1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeTable myForm = new TimeTable();
            myForm.Show(this);
            this.Hide();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.Image = img2;
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Devices dev = new Devices();
            dev.Show(this);
            this.Hide();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            startSoundPlayer1.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startSoundPlayer1.Play();
            Process.Start(Path.Combine(System.Windows.Forms.Application.StartupPath, "help.html"));
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            endless endl = new endless();
            endl.Show(this);
            this.Hide();
        }
    }
}
