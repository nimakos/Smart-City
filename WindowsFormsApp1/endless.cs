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
    public partial class endless : Form
    {

        Bitmap endles = Properties.Resources._4300;
        Bitmap endles_1 = Properties.Resources._4300sda;
        Bitmap snow_TV = Properties.Resources.giphy;

        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(Properties.Resources._20185__patchen__foot_stomp_c);


        public endless()
        {
            InitializeComponent();
        }

        private void endless_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = endles;
            
            YourFunction();
        }

        private void endless_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private async void YourFunction()
        {            
            await Task.Delay(5000);
            startSoundPlayer.Play();
            pictureBox1.Image = snow_TV;
            await Task.Delay(5000);
            pictureBox1.Image = endles_1;

            string message = "Παθατέ κάτι;";
            string caption = "Alert!!!!!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                MessageBox.Show("Παρακαλώ δώστε μου μια επιλογή");
                label3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                button1.Visible = true;
                


            }
            else
            {
                MessageBox.Show("Αν χρειαστείτε οτιδήποτε ειδοποιείστε μας");
            }




        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Ο γιατρός θα είναι στο σπίτι σας σε 10 λεπτά");
            }
            else if (radioButton2.Checked == true)
            {
                //MessageBox.Show("Τα τρόφιμα θα είναι στο σπίτι σας σε μισή ώρα");
                Foodstore myForm = new Foodstore();
                myForm.Show(this);
                this.Hide();
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("Η αστυνομία έχει ειδοποιηθεί και θα είναι σπίτι σε 5 λεπτά ");
            }
            else if (radioButton4.Checked == true)
            {
                MessageBox.Show("Το συνεργείο καθαρισμού θα είναι εκεί σε 15 λεπτα ");
            }
        }
    }
}
