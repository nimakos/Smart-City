namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userCBox = new System.Windows.Forms.TextBox();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.LognButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.userCBox);
            this.panel1.Controls.Add(this.Register_Btn);
            this.panel1.Controls.Add(this.passBox);
            this.panel1.Controls.Add(this.LognButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(224, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 99);
            this.panel1.TabIndex = 1;
            // 
            // userCBox
            // 
            this.userCBox.Location = new System.Drawing.Point(180, 15);
            this.userCBox.Name = "userCBox";
            this.userCBox.Size = new System.Drawing.Size(92, 20);
            this.userCBox.TabIndex = 4;
            // 
            // Register_Btn
            // 
            this.Register_Btn.BackColor = System.Drawing.Color.YellowGreen;
            this.Register_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Register_Btn.Location = new System.Drawing.Point(318, 50);
            this.Register_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(74, 23);
            this.Register_Btn.TabIndex = 6;
            this.Register_Btn.Text = "Εγγραφή";
            this.Register_Btn.UseVisualStyleBackColor = false;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(180, 52);
            this.passBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(92, 20);
            this.passBox.TabIndex = 2;
            // 
            // LognButton
            // 
            this.LognButton.BackColor = System.Drawing.Color.YellowGreen;
            this.LognButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LognButton.Location = new System.Drawing.Point(318, 15);
            this.LognButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LognButton.Name = "LognButton";
            this.LognButton.Size = new System.Drawing.Size(74, 23);
            this.LognButton.TabIndex = 4;
            this.LognButton.Text = "Σύνδεση";
            this.LognButton.UseVisualStyleBackColor = false;
            this.LognButton.Click += new System.EventHandler(this.LognButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Κωδικός";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Όνομα Χρήστη";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 457);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LognButton;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button Register_Btn;
        private System.Windows.Forms.TextBox userCBox;
    }
}

