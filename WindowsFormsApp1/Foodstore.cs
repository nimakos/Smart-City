using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Foodstore : Form
    {
        private List<Food> foodlist =new List<Food>();
        private List<Food> shoppinglist = new List<Food>();
        
        public Foodstore()
        {
            InitializeComponent();
        }

        public FileInfo FoodsFile
        {
            get
            {
                return new FileInfo(Path.Combine(Application.StartupPath, "foods.xml"));
            }
        }

        private void Foodstore_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            List<Food> lst=new List<Food>();
            if (FoodsFile.Exists)
            {
                XmlSerializer xml = new XmlSerializer(lst.GetType());
                using (Stream s = FoodsFile.OpenRead())
                {
                    lst = xml.Deserialize(s) as List<Food>;
                }
                foreach (Food item in lst)
                {
                    Food fd = new Food(item.name, item.price, item.description, item.critics, item.imgpath);
                    foodlist.Add(fd);                  
                }
                foodlistbox.Items.Clear();
                foreach (Food item in foodlist)
                {
                    foodlistbox.Items.Add(String.Format("{0}", item.name));
                }
            }
        }

        private void Foodstore_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Food> lst = new List<Food>();

            foreach (Food item in foodlist)
            {
                lst.Add(new Food(item.name, item.price, item.description, item.critics, item.imgpath));
            }
            //lst.Add(new Food("foodname", 9.99, "some descriptions", "some critics", "the image path"));
            XmlSerializer xmls = new XmlSerializer(lst.GetType());

            if (FoodsFile.Exists)
            {
                FoodsFile.Delete();
            }
            using (Stream s = FoodsFile.OpenWrite())
            {
                xmls.Serialize(s, lst);
                s.Close();
            }
        }

        private void searchbox_Click(object sender, EventArgs e)
        {
            searchbox.Text = "";
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            List<Food> temp = new List<Food>();
            bool results=false;
            foreach (Food item in foodlist)
            {
                if (String.Format("{0}", item.name).ToLower().Contains(searchbox.Text.ToLower().Trim())){
                        temp.Add(item);
                        results=true;
                }
            }
            foodlistbox.Items.Clear();
            foreach (Food fd in temp)
            {
                foodlistbox.Items.Add(String.Format("{0}", fd.name));
            }
            if (!results)
            {
                foodlistbox.Items.Add("Δεν βρέθηκε κανένα προϊόν");
            }
        }

        private void foodlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Food fd in foodlist)
            {
                try {
                    if ((String.Format("{0}", fd.name)).Equals(foodlistbox.SelectedItem.ToString()))
                    {
                        foodinfoname.Text = String.Copy(fd.name);
                        foodinfocritics.Text = "Κριτικές:" + Environment.NewLine + fd.critics;
                        foodinfopicture.Load("foodimages\\" + fd.imgpath);
                        foodinfoprice.Text = fd.price.ToString() + ((char)0x20AC).ToString();
                        foodinfodescription.Text = "Περιγραφή:" + Environment.NewLine + fd.description;
                        if (fd.getquantity() > 0)
                        {
                            removefromcart.Visible = true;
                            quantityvalue.Value = fd.getquantity();
                        }
                        else
                        {
                            quantityvalue.Value = 1;
                            removefromcart.Visible = false;
                        }
                    }
                }
                catch(NullReferenceException )
                {

                }
                
            }
            cartpanel.Visible = false;
            
            //foodinfopanel.Location = new System.Drawing.Point(845, 86);
            foodinfopanel.Visible = true;
             
            
        }

        private void addcartbutton_Click(object sender, EventArgs e)
        {
            string message = "Θα θέλατε να το προσθέσετε στο καλάθι σας;";
            string caption = "Προσθήκη στο καλάθι";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (Food fd in foodlist)
                {
                    if (String.Format("{0}", fd.name).Equals(foodlistbox.SelectedItem.ToString()))
                    {
                        if (!shoppinglist.Contains(fd))
                        {
                            fd.setquantity(Convert.ToInt32(quantityvalue.Value));
                            shoppinglist.Add(fd);
                            removefromcart.Visible = true;
                        }
                        else
                        {
                            fd.setquantity(Convert.ToInt32(quantityvalue.Value));
                        }
                    }
                }
            }
        }

        private void removefromcart_Click(object sender, EventArgs e)
        {
            int pos = 0;
            foreach (Food fd in shoppinglist)
            {
                if (fd.name.Equals(foodinfoname.Text))
                {
                    fd.setquantity(0);
                    break;
                }
                pos++;
            }
            shoppinglist.RemoveAt(pos);
            removefromcart.Visible = false;
            quantityvalue.Value = 1;
        }

        private void cartbutton_Click(object sender, EventArgs e)
        {

            foodinfopanel.Visible = false;
            //cartpanel.Location = new System.Drawing.Point(620, 0);
            
            int num=1;
            double cost = 0.0;
            shoppingcartlistview.Items.Clear();
            foreach (Food fd in shoppinglist)
            {
                
                ListViewItem item = new ListViewItem(num.ToString());
                item.SubItems.Add(fd.name);
                item.SubItems.Add(fd.getquantity().ToString());
                item.SubItems.Add((fd.price*fd.getquantity()).ToString());
                shoppingcartlistview.Items.Add(item);
                num++;
                cost += fd.price*fd.getquantity();
            }
            totalcostlabel.Text ="Συνολικό Κόστος: " + cost.ToString()  + ((char)0x20AC).ToString();

            cartpanel.Visible = true;

        }

        private void shoppingcartlistview_DoubleClick(object sender, EventArgs e)
        {
            if (shoppingcartlistview.SelectedItems.Count == 1)
            {
                foreach (Food fd in foodlist)
                {
                    foreach (ListViewItem lvi in shoppingcartlistview.Items)
                    {
                        if (lvi.SubItems[1].Text.Equals(fd.name))
                        {
                            foodlistbox.SelectedIndex = foodlistbox.FindString(fd.name);
                            foodinfoname.Text = String.Copy(fd.name);
                            foodinfopicture.Load("foodimages\\" + fd.imgpath);
                            foodinfoprice.Text = fd.price.ToString() +"e";
                            foodinfodescription.Text = "Περιγραφή:" + Environment.NewLine + fd.description;
                            if (fd.getquantity() > 0)
                            {
                                removefromcart.Visible = true;
                            }
                            else
                            {
                                removefromcart.Visible = false;
                            }
                        }
                    }
                }
                cartpanel.Visible = false;
                //foodinfopanel.Location = new System.Drawing.Point(757, 0);
                foodinfopanel.Visible = true;
            }
        }
        
        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (shoppingcartlistview.Items.Count > 0)
            {
                string message = "Θα θέλατε να προχωρήσετε την παραγγελία σας;";
                string caption = "Υποβολή καλαθιού";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    cartpanel.Visible = false;
                   
                    MessageBox.Show("H παραγγελία σας ολοκληρώθηκε επιτυχώς, μπορείτε να περάσετε να τον παραλάβετε ");
                }
            }
            else
            {
                MessageBox.Show("Παρακαλώ αγοράστε πρώτα κάτι!", "Άδειο Καλάθι", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ordercancelbutton_Click(object sender, EventArgs e)
        {
            string message = "Θα θέλατε να ακυρώσετε την παραγγελία σας;";
            string caption = "Παραγγελία";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
             
                //cartpanel.Location = new System.Drawing.Point(620, 35);
                cartpanel.Visible = true;
            }
        }

        private void Foodstore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
