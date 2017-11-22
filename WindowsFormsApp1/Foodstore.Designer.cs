namespace WindowsFormsApp1
{
    partial class Foodstore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foodstore));
            this.searchbox = new System.Windows.Forms.TextBox();
            this.cartpanel = new System.Windows.Forms.Panel();
            this.shoppingcartlistview = new System.Windows.Forms.ListView();
            this.nocolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewtitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewquantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalcostlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buylabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.foodinfopanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityvalue = new System.Windows.Forms.NumericUpDown();
            this.removefromcart = new System.Windows.Forms.Button();
            this.foodinfodescription = new System.Windows.Forms.Label();
            this.foodinfopicture = new System.Windows.Forms.PictureBox();
            this.addcartbutton = new System.Windows.Forms.Button();
            this.foodinfoprice = new System.Windows.Forms.Label();
            this.foodinfoname = new System.Windows.Forms.Label();
            this.foodinfolabel = new System.Windows.Forms.Label();
            this.foodinfocritics = new System.Windows.Forms.Label();
            this.foodlistbox = new System.Windows.Forms.ListBox();
            this.cartbutton = new System.Windows.Forms.Button();
            this.cartpanel.SuspendLayout();
            this.foodinfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityvalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodinfopicture)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(263, 55);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(311, 22);
            this.searchbox.TabIndex = 3;
            this.searchbox.Text = "Πληκτρολογήστε εδώ για αναζήτηση...";
            this.searchbox.Click += new System.EventHandler(this.searchbox_Click);
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // cartpanel
            // 
            this.cartpanel.BackColor = System.Drawing.Color.Transparent;
            this.cartpanel.Controls.Add(this.shoppingcartlistview);
            this.cartpanel.Controls.Add(this.totalcostlabel);
            this.cartpanel.Controls.Add(this.label1);
            this.cartpanel.Controls.Add(this.buylabel);
            this.cartpanel.Controls.Add(this.button3);
            this.cartpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.cartpanel.Location = new System.Drawing.Point(167, 0);
            this.cartpanel.Margin = new System.Windows.Forms.Padding(4);
            this.cartpanel.Name = "cartpanel";
            this.cartpanel.Size = new System.Drawing.Size(627, 859);
            this.cartpanel.TabIndex = 5;
            this.cartpanel.Visible = false;
            // 
            // shoppingcartlistview
            // 
            this.shoppingcartlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nocolumn,
            this.listviewtitle,
            this.listviewquantity,
            this.listviewprice});
            this.shoppingcartlistview.FullRowSelect = true;
            this.shoppingcartlistview.Location = new System.Drawing.Point(40, 126);
            this.shoppingcartlistview.Margin = new System.Windows.Forms.Padding(4);
            this.shoppingcartlistview.Name = "shoppingcartlistview";
            this.shoppingcartlistview.Size = new System.Drawing.Size(572, 442);
            this.shoppingcartlistview.TabIndex = 8;
            this.shoppingcartlistview.UseCompatibleStateImageBehavior = false;
            this.shoppingcartlistview.View = System.Windows.Forms.View.Details;
            this.shoppingcartlistview.DoubleClick += new System.EventHandler(this.shoppingcartlistview_DoubleClick);
            // 
            // nocolumn
            // 
            this.nocolumn.Text = "No";
            this.nocolumn.Width = 26;
            // 
            // listviewtitle
            // 
            this.listviewtitle.Text = "Περιγραφή";
            this.listviewtitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listviewtitle.Width = 275;
            // 
            // listviewquantity
            // 
            this.listviewquantity.Text = "Ποσότητα";
            this.listviewquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.listviewquantity.Width = 65;
            // 
            // listviewprice
            // 
            this.listviewprice.Text = "Τιμή";
            this.listviewprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalcostlabel
            // 
            this.totalcostlabel.AutoSize = true;
            this.totalcostlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalcostlabel.Location = new System.Drawing.Point(425, 518);
            this.totalcostlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalcostlabel.Name = "totalcostlabel";
            this.totalcostlabel.Size = new System.Drawing.Size(61, 17);
            this.totalcostlabel.TabIndex = 7;
            this.totalcostlabel.Text = "Σύνολο";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 2);
            this.label1.TabIndex = 6;
            // 
            // buylabel
            // 
            this.buylabel.AutoSize = true;
            this.buylabel.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buylabel.Location = new System.Drawing.Point(152, 0);
            this.buylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buylabel.Name = "buylabel";
            this.buylabel.Size = new System.Drawing.Size(311, 45);
            this.buylabel.TabIndex = 4;
            this.buylabel.Text = "Το καλάθι μου";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(500, 576);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Υποβολή";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // foodinfopanel
            // 
            this.foodinfopanel.BackColor = System.Drawing.Color.Transparent;
            this.foodinfopanel.Controls.Add(this.label2);
            this.foodinfopanel.Controls.Add(this.quantityvalue);
            this.foodinfopanel.Controls.Add(this.removefromcart);
            this.foodinfopanel.Controls.Add(this.foodinfodescription);
            this.foodinfopanel.Controls.Add(this.foodinfopicture);
            this.foodinfopanel.Controls.Add(this.addcartbutton);
            this.foodinfopanel.Controls.Add(this.foodinfoprice);
            this.foodinfopanel.Controls.Add(this.foodinfoname);
            this.foodinfopanel.Controls.Add(this.foodinfolabel);
            this.foodinfopanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.foodinfopanel.Location = new System.Drawing.Point(794, 0);
            this.foodinfopanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodinfopanel.Name = "foodinfopanel";
            this.foodinfopanel.Size = new System.Drawing.Size(977, 859);
            this.foodinfopanel.TabIndex = 5;
            this.foodinfopanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(639, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ποσότητα";
            // 
            // quantityvalue
            // 
            this.quantityvalue.Location = new System.Drawing.Point(724, 361);
            this.quantityvalue.Margin = new System.Windows.Forms.Padding(4);
            this.quantityvalue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityvalue.Name = "quantityvalue";
            this.quantityvalue.Size = new System.Drawing.Size(47, 22);
            this.quantityvalue.TabIndex = 10;
            this.quantityvalue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // removefromcart
            // 
            this.removefromcart.BackColor = System.Drawing.Color.Firebrick;
            this.removefromcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.removefromcart.Location = new System.Drawing.Point(541, 313);
            this.removefromcart.Margin = new System.Windows.Forms.Padding(4);
            this.removefromcart.Name = "removefromcart";
            this.removefromcart.Size = new System.Drawing.Size(156, 31);
            this.removefromcart.TabIndex = 9;
            this.removefromcart.Text = "Δεν το θέλω";
            this.removefromcart.UseVisualStyleBackColor = false;
            this.removefromcart.Visible = false;
            this.removefromcart.Click += new System.EventHandler(this.removefromcart_Click);
            // 
            // foodinfodescription
            // 
            this.foodinfodescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodinfodescription.Location = new System.Drawing.Point(573, 215);
            this.foodinfodescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodinfodescription.Name = "foodinfodescription";
            this.foodinfodescription.Size = new System.Drawing.Size(289, 86);
            this.foodinfodescription.TabIndex = 8;
            this.foodinfodescription.Text = "Description";
            // 
            // foodinfopicture
            // 
            this.foodinfopicture.Location = new System.Drawing.Point(39, 295);
            this.foodinfopicture.Margin = new System.Windows.Forms.Padding(4);
            this.foodinfopicture.Name = "foodinfopicture";
            this.foodinfopicture.Size = new System.Drawing.Size(251, 190);
            this.foodinfopicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodinfopicture.TabIndex = 7;
            this.foodinfopicture.TabStop = false;
            // 
            // addcartbutton
            // 
            this.addcartbutton.BackColor = System.Drawing.Color.Firebrick;
            this.addcartbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addcartbutton.Location = new System.Drawing.Point(759, 313);
            this.addcartbutton.Margin = new System.Windows.Forms.Padding(4);
            this.addcartbutton.Name = "addcartbutton";
            this.addcartbutton.Size = new System.Drawing.Size(173, 31);
            this.addcartbutton.TabIndex = 4;
            this.addcartbutton.Text = "Το θέλω";
            this.addcartbutton.UseVisualStyleBackColor = false;
            this.addcartbutton.Click += new System.EventHandler(this.addcartbutton_Click);
            // 
            // foodinfoprice
            // 
            this.foodinfoprice.AutoSize = true;
            this.foodinfoprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodinfoprice.Location = new System.Drawing.Point(575, 137);
            this.foodinfoprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodinfoprice.Name = "foodinfoprice";
            this.foodinfoprice.Size = new System.Drawing.Size(56, 22);
            this.foodinfoprice.TabIndex = 1;
            this.foodinfoprice.Text = "Price";
            // 
            // foodinfoname
            // 
            this.foodinfoname.AutoSize = true;
            this.foodinfoname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.foodinfoname.Location = new System.Drawing.Point(573, 55);
            this.foodinfoname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodinfoname.Name = "foodinfoname";
            this.foodinfoname.Size = new System.Drawing.Size(68, 25);
            this.foodinfoname.TabIndex = 1;
            this.foodinfoname.Text = "Name";
            // 
            // foodinfolabel
            // 
            this.foodinfolabel.AutoSize = true;
            this.foodinfolabel.Font = new System.Drawing.Font("Century Schoolbook", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodinfolabel.Location = new System.Drawing.Point(136, 10);
            this.foodinfolabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodinfolabel.Name = "foodinfolabel";
            this.foodinfolabel.Size = new System.Drawing.Size(439, 45);
            this.foodinfolabel.TabIndex = 0;
            this.foodinfolabel.Text = "Λεπτομέρειες Μενού";
            // 
            // foodinfocritics
            // 
            this.foodinfocritics.BackColor = System.Drawing.Color.Transparent;
            this.foodinfocritics.Location = new System.Drawing.Point(688, 729);
            this.foodinfocritics.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foodinfocritics.Name = "foodinfocritics";
            this.foodinfocritics.Size = new System.Drawing.Size(567, 92);
            this.foodinfocritics.TabIndex = 6;
            this.foodinfocritics.Text = "Critics";
            this.foodinfocritics.Visible = false;
            // 
            // foodlistbox
            // 
            this.foodlistbox.BackColor = System.Drawing.SystemColors.Window;
            this.foodlistbox.FormattingEnabled = true;
            this.foodlistbox.ItemHeight = 16;
            this.foodlistbox.Location = new System.Drawing.Point(161, 98);
            this.foodlistbox.Margin = new System.Windows.Forms.Padding(4);
            this.foodlistbox.Name = "foodlistbox";
            this.foodlistbox.Size = new System.Drawing.Size(504, 324);
            this.foodlistbox.TabIndex = 6;
            this.foodlistbox.SelectedIndexChanged += new System.EventHandler(this.foodlistbox_SelectedIndexChanged);
            // 
            // cartbutton
            // 
            this.cartbutton.BackColor = System.Drawing.Color.Firebrick;
            this.cartbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbutton.Location = new System.Drawing.Point(263, 609);
            this.cartbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cartbutton.Name = "cartbutton";
            this.cartbutton.Size = new System.Drawing.Size(312, 36);
            this.cartbutton.TabIndex = 7;
            this.cartbutton.Text = "Το καλάθι μου";
            this.cartbutton.UseVisualStyleBackColor = false;
            this.cartbutton.Click += new System.EventHandler(this.cartbutton_Click);
            // 
            // Foodstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1771, 859);
            this.Controls.Add(this.cartbutton);
            this.Controls.Add(this.cartpanel);
            this.Controls.Add(this.foodinfopanel);
            this.Controls.Add(this.foodlistbox);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.foodinfocritics);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Foodstore";
            this.Text = "Παραγγελίες";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Foodstore_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Foodstore_FormClosed);
            this.Load += new System.EventHandler(this.Foodstore_Load);
            this.cartpanel.ResumeLayout(false);
            this.cartpanel.PerformLayout();
            this.foodinfopanel.ResumeLayout(false);
            this.foodinfopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityvalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodinfopicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Panel cartpanel;
        private System.Windows.Forms.Label buylabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel foodinfopanel;
        private System.Windows.Forms.Button addcartbutton;
        private System.Windows.Forms.Label foodinfoname;
        private System.Windows.Forms.Label foodinfolabel;
        private System.Windows.Forms.ListBox foodlistbox;
        private System.Windows.Forms.Button cartbutton;
        private System.Windows.Forms.Label foodinfocritics;
        private System.Windows.Forms.PictureBox foodinfopicture;
        private System.Windows.Forms.Label foodinfodescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalcostlabel;
        private System.Windows.Forms.ListView shoppingcartlistview;
        private System.Windows.Forms.ColumnHeader nocolumn;
        private System.Windows.Forms.ColumnHeader listviewtitle;
        private System.Windows.Forms.ColumnHeader listviewquantity;
        private System.Windows.Forms.ColumnHeader listviewprice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown quantityvalue;
        private System.Windows.Forms.Button removefromcart;
        private System.Windows.Forms.Label foodinfoprice;
    }
}