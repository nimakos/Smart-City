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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)  //Phone
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 127 && ch != '+')
            {
                e.Handled = true;
            }
        }

        private void userBox_KeyPress(object sender, KeyPressEventArgs e) //Username
        {
            char ch = e.KeyChar;
            if (ch == ' ')
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int age = System.DateTime.Now.Year - dateTimePicker1.Value.Year;
            label8.Text = age.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            if(passBox.Text == passBox2.Text && !string.IsNullOrWhiteSpace(userBox.Text) && !string.IsNullOrWhiteSpace(passBox.Text) && !string.IsNullOrWhiteSpace(passBox2.Text))
            {
                ((LoginForm)this.Owner).setUsername(userBox.Text);
                ((LoginForm)this.Owner).setPassword(passBox.Text);
                MessageBox.Show("Ο χρήστης δημιουργήθηκε με επιτυχία");
            }
            if (passBox.Text != passBox2.Text && !string.IsNullOrWhiteSpace(passBox.Text) && !string.IsNullOrWhiteSpace(passBox2.Text))
             {
                MessageBox.Show("Οι κωδικοί δεν ταιριάζουν");
            }
            if ( string.IsNullOrWhiteSpace(userBox.Text) || string.IsNullOrWhiteSpace(passBox.Text) || string.IsNullOrWhiteSpace(passBox2.Text))
            {
                MessageBox.Show("Παρακαλώ συμπληρώστε όλα τα πεδία");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void mailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == ' ' )
            {
                e.Handled = true;
            }
        }
    }
}
