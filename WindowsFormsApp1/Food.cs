using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    public class Food
    {        
        public string name;
        public double price;
        public string description;
        public string critics;
        public string imgpath;
        private int quantity = 0;

        public Food(string nm, double pr, string desc, string crt, string im)
        {
            this.name = String.Copy(nm);
            this.price = pr;
            this.description = String.Copy(desc);
            this.critics = String.Copy(crt);
            this.imgpath = im;
        }

        public Food()
        {   }

        public void setquantity(int q)
        {
            this.quantity = q;
        }

        public int getquantity()
        {
            return this.quantity;
        }
    }
}
