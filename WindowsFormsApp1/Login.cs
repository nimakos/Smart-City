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
    public partial class LoginForm : Form
    {
        private String username = "admin";
        private String pass = "admin";

    
        public LoginForm()
        {
           
            InitializeComponent();
        }


        public void setUsername(String u)
        {
            username = u;
        }

        public void setPassword(String p)
        {
            pass = p;
        }


        private Boolean checkCredentials()
        {
            return (userCBox.Text == username && passBox.Text == pass);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void LognButton_Click(object sender, EventArgs e)
        {
            main map = new main();


            if (checkCredentials())
            {

                MessageBox.Show("Επιτυχής σύνδεση");
                map.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Λάθος Εισαγωγή δεδομένων");
            }
        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            Register myForm = new Register();
            myForm.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main myForm = new main();
            myForm.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foodstore myForm = new Foodstore();
            myForm.Show(this);
            this.Hide();
        }
    }
}
