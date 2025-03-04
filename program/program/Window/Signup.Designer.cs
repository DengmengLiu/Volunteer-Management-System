namespace program
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closebtn = new Button();
            gender = new ComboBox();
            error = new Label();
            back = new Button();
            create = new Button();
            ucpass = new TextBox();
            upass = new TextBox();
            uemail = new TextBox();
            uphone = new TextBox();
            uname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 51, 73);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 769);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(302, 422);
            label3.Name = "label3";
            label3.Size = new Size(139, 43);
            label3.TabIndex = 7;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 360);
            label2.Name = "label2";
            label2.Size = new Size(417, 43);
            label2.TabIndex = 6;
            label2.Text = "Volunteer Mangement";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 292);
            label1.Name = "label1";
            label1.Size = new Size(301, 43);
            label1.TabIndex = 5;
            label1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(closebtn);
            panel2.Controls.Add(gender);
            panel2.Controls.Add(error);
            panel2.Controls.Add(back);
            panel2.Controls.Add(create);
            panel2.Controls.Add(ucpass);
            panel2.Controls.Add(upass);
            panel2.Controls.Add(uemail);
            panel2.Controls.Add(uphone);
            panel2.Controls.Add(uname);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(462, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(770, 769);
            panel2.TabIndex = 1;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.Transparent;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            closebtn.ForeColor = Color.FromArgb(24, 30, 54);
            closebtn.Location = new Point(730, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 8;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            gender.Location = new Point(369, 305);
            gender.Name = "gender";
            gender.Size = new Size(268, 32);
            gender.TabIndex = 20;
            gender.SelectedIndex = 0;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            error.ForeColor = Color.Red;
            error.Location = new Point(286, 591);
            error.Name = "error";
            error.Size = new Size(385, 25);
            error.TabIndex = 19;
            error.Text = "Those passwords didn't match. Try again.";
            error.Visible = false;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(24, 30, 54);
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back.ForeColor = Color.White;
            back.Location = new Point(632, 645);
            back.Name = "back";
            back.Size = new Size(126, 50);
            back.TabIndex = 18;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // create
            // 
            create.BackColor = Color.FromArgb(24, 30, 54);
            create.FlatStyle = FlatStyle.Flat;
            create.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            create.ForeColor = Color.White;
            create.Location = new Point(448, 645);
            create.Name = "create";
            create.Size = new Size(133, 50);
            create.TabIndex = 17;
            create.TabStop = false;
            create.Text = "Create";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // ucpass
            // 
            ucpass.Location = new Point(369, 541);
            ucpass.Name = "ucpass";
            ucpass.Size = new Size(268, 30);
            ucpass.TabIndex = 16;
            ucpass.UseSystemPasswordChar = true;
            // 
            // upass
            // 
            upass.Location = new Point(369, 480);
            upass.Name = "upass";
            upass.Size = new Size(268, 30);
            upass.TabIndex = 15;
            upass.UseSystemPasswordChar = true;
            // 
            // uemail
            // 
            uemail.Location = new Point(369, 425);
            uemail.Name = "uemail";
            uemail.Size = new Size(268, 30);
            uemail.TabIndex = 14;
            // 
            // uphone
            // 
            uphone.Location = new Point(369, 363);
            uphone.Name = "uphone";
            uphone.Size = new Size(268, 30);
            uphone.TabIndex = 13;
            // 
            // uname
            // 
            uname.Location = new Point(369, 250);
            uname.Name = "uname";
            uname.Size = new Size(268, 30);
            uname.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(15, 538);
            label10.Name = "label10";
            label10.Size = new Size(233, 31);
            label10.TabIndex = 6;
            label10.Text = "Confirm password :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(113, 477);
            label9.Name = "label9";
            label9.Size = new Size(135, 31);
            label9.TabIndex = 5;
            label9.Text = "Password :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(161, 422);
            label8.Name = "label8";
            label8.Size = new Size(87, 31);
            label8.TabIndex = 4;
            label8.Text = "Email :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(147, 360);
            label7.Name = "label7";
            label7.Size = new Size(101, 31);
            label7.TabIndex = 3;
            label7.Text = "Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(136, 302);
            label6.Name = "label6";
            label6.Size = new Size(112, 31);
            label6.TabIndex = 2;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 247);
            label5.Name = "label5";
            label5.Size = new Size(96, 31);
            label5.TabIndex = 1;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(20, 97);
            label4.Name = "label4";
            label4.Size = new Size(499, 62);
            label4.TabIndex = 0;
            label4.Text = "Create your Account";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 769);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox ucpass;
        private TextBox upass;
        private TextBox uemail;
        private TextBox uphone;
        private TextBox uname;
        private Button back;
        private Button create;
        private Label error;
        private ComboBox gender;
        private Button closebtn;
    }
}