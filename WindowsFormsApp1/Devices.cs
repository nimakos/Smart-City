using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Devices : Form
    {
        private bool button6WasClicked = false;
        private bool button7WasClicked = false;

        Bitmap dark_closeTV = Properties.Resources.new_dark_closeTV1_;
        Bitmap light_closeTV = Properties.Resources.light_without_spot_closeTV;
        Bitmap light_openTV = Properties.Resources.light_without_spot_openTV;
        Bitmap dark_openTV = Properties.Resources.new_dark_openTV1_;

        Bitmap dark_closeTV1 = Properties.Resources.small_JK_23371_DARK_CLOSETV;
        Bitmap light_closeTV1 = Properties.Resources.small_JK_23371_TV_CLOSED;
        Bitmap light_openTV1 = Properties.Resources.small_JK_23371;
        Bitmap dark_openTV1 = Properties.Resources.small_JK_23371_DARK_OPENTV;

        Bitmap button_red = Properties.Resources.red_white_power_button_symbol_icon_30;
        Bitmap button_green = Properties.Resources.green_power_button_symbol_icon_20;        

        Bitmap air_closed = Properties.Resources.air_condition_icon_png_21_closed;
        Bitmap air_opened = Properties.Resources.air_condition_icon_png_21;

        Bitmap kitchen_Light_closed = Properties.Resources.KITCHENCLOSED_LIGHTS;
        Bitmap kitchen_Light_opened = Properties.Resources.KICHEN_OPEN_LIGHTS;

        Bitmap on_Water = Properties.Resources.switch_on_icon;
        Bitmap Off_Water = Properties.Resources.switch_off_icon;

        private int plus = 20;

        public Devices()
        {
          
            InitializeComponent();
        }

        private void Devices_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == dark_closeTV)
            {
                pictureBox1.Image = light_closeTV;
            }
            else if (pictureBox1.Image == light_closeTV)
            {
                pictureBox1.Image = dark_closeTV;
            }
            else if (pictureBox1.Image == light_openTV)
            {
                pictureBox1.Image = dark_openTV;
            }
            else if (pictureBox1.Image == dark_openTV)
            {
                pictureBox1.Image = light_openTV;
            }



            if (pictureBox2.Image == dark_closeTV1)
            {
                pictureBox2.Image = light_closeTV1;
            }
            else if (pictureBox2.Image == light_closeTV1)
            {
                pictureBox2.Image = dark_closeTV1;
            }
            else if (pictureBox2.Image == light_openTV1)
            {
                pictureBox2.Image = dark_openTV1;
            }
            else if (pictureBox2.Image == dark_openTV1)
            {
                pictureBox2.Image = light_openTV1;
            }


            if (pictureBox4.Image == kitchen_Light_closed)
            {
                pictureBox4.Image = kitchen_Light_opened;
            }
            else if (pictureBox4.Image == kitchen_Light_opened)
            {
                pictureBox4.Image = kitchen_Light_closed;
            }


            if (button1.BackgroundImage == button_red)
            {
                button1.BackgroundImage = button_green;
            }
            else if (button1.BackgroundImage == button_green)
            {
                button1.BackgroundImage = button_red;
            }

        }

        private void Devices_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            pictureBox1.Image = dark_closeTV;
            pictureBox2.Image = dark_closeTV1;
            button1.BackgroundImage = button_red;
            button5.BackgroundImage = air_closed;
            pictureBox4.Image = kitchen_Light_closed;
            button8.BackgroundImage = Off_Water;
            button9.BackgroundImage = Off_Water;
            button10.BackgroundImage = Off_Water;
            button11.BackgroundImage = Off_Water;
            button12.BackgroundImage = Off_Water;
            button13.BackgroundImage = Off_Water;
        }


        private void button1_MouseEnter(object sender, EventArgs e)
        {
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == dark_closeTV)
            {
                pictureBox1.Image = dark_openTV;
            }
            else if (pictureBox1.Image == light_closeTV)
            {
                pictureBox1.Image = light_openTV;
            }
            else if (pictureBox1.Image == dark_openTV)
            {
                pictureBox1.Image = dark_closeTV;
            }
            else if (pictureBox1.Image == light_openTV)
            {
                pictureBox1.Image = light_closeTV;
            }



            if (pictureBox2.Image == dark_closeTV1)
            {
                pictureBox2.Image = dark_openTV1;
            }
            else if (pictureBox2.Image == light_closeTV1)
            {
                pictureBox2.Image = light_openTV1;
            }
            else if (pictureBox2.Image == dark_openTV1)
            {
                pictureBox2.Image = dark_closeTV1;
            }
            else if (pictureBox2.Image == light_openTV1)
            {
                pictureBox2.Image = light_closeTV1;
            }


            
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (plus < 30)
            {
                if (button6WasClicked)
                {

                    plus = plus + 1;
                    txtDisplay.Text = plus.ToString() + " °C   ☀";


                }
                else if (button7WasClicked)
                {

                    plus = plus + 1;
                    txtDisplay.Text = plus.ToString() + " °C   ❄";

                }
                else
                {
                    plus = plus + 1;
                    txtDisplay.Text = plus.ToString() + " °C   ❄";
                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (plus > 17)
            {

                if (button6WasClicked)
                {

                    plus = plus - 1;
                    txtDisplay.Text = plus.ToString() + " °C   ☀";


                }
                else if (button7WasClicked)
                {

                    plus = plus - 1;
                    txtDisplay.Text = plus.ToString() + " °C   ❄";

                }
                else
                {
                    plus = plus - 1;
                    txtDisplay.Text = plus.ToString() + " °C   ❄";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(button5.BackgroundImage == air_closed)
            {
                button5.BackgroundImage = air_opened;
                txtDisplay.Text = plus.ToString() + " °C   ❄";
            }
            else if(button5.BackgroundImage == air_opened)
            {
                button5.BackgroundImage = air_closed;
                txtDisplay.Text = "- °C   ❄";
            }
        }
    

        private void button6_Click(object sender, EventArgs e)
        {
            button6WasClicked = true;
            button7WasClicked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6WasClicked = false;
            button7WasClicked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            if (progressBar1.Value == 100)
            {
                
                this.timer1.Stop();
                MessageBox.Show("Δοχείο συλλογής νερού στη θέση του");
                progressBar1.Visible = false;
        
            }
        }      

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Increment(4);
            if (progressBar2.Value == 100)
            {

                this.timer2.Stop();
                MessageBox.Show("Δοχείο συλλογής νερού στη θέση του");
                progressBar2.Visible = false;
               
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackgroundImage == Off_Water)
            {
                button8.BackgroundImage = on_Water;
                this.timer1.Start();
                progressBar1.Visible = true;
            }
            else if (button8.BackgroundImage == on_Water)
            {
                button8.BackgroundImage = Off_Water;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackgroundImage == Off_Water)
            {
                button9.BackgroundImage = on_Water;
                this.timer2.Start();
                progressBar2.Visible = true;
            }
            else if (button9.BackgroundImage == on_Water)
            {
                button9.BackgroundImage = Off_Water;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackgroundImage == Off_Water)
            {
                button10.BackgroundImage = on_Water;
                MessageBox.Show("Ο Συναγερμός Ενεργοποιήθηκε");
               
            }
            else if (button10.BackgroundImage == on_Water)
            {
                button10.BackgroundImage = Off_Water;
                MessageBox.Show("Ο Συναγερμός Απενεργοποιήθηκε");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackgroundImage == Off_Water)
            {
                button11.BackgroundImage = on_Water;
                MessageBox.Show("Όλες οι Πόρτες έχουν κλειδώσει");

            }
            else if (button11.BackgroundImage == on_Water)
            {
                button11.BackgroundImage = Off_Water;
                MessageBox.Show("Όλες οι πόρτες είναι ξεκλείδωτες");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackgroundImage == Off_Water)
            {
                button12.BackgroundImage = on_Water;
                MessageBox.Show("Το ποτιστικό ενεργοποιήθηκε");

            }
            else if (button12.BackgroundImage == on_Water)
            {
                button12.BackgroundImage = Off_Water;
                MessageBox.Show("Το ποτιστικό απενεργοποιήθηκε");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackgroundImage == Off_Water)
            {
                button13.BackgroundImage = on_Water;
                MessageBox.Show("Ζεστό νερό χρήσης ενεργοποιημένο");

            }
            else if (button13.BackgroundImage == on_Water)
            {
                button13.BackgroundImage = Off_Water;
                MessageBox.Show("Ζεστό νερό χρήσης απενεργοποιημένο");
            }
        }
    }
}
