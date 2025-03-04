namespace program.Window
{
    partial class Userinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            change = new Button();
            gender = new ComboBox();
            time = new Label();
            upass = new TextBox();
            label3 = new Label();
            uemail = new TextBox();
            label2 = new Label();
            uphone = new TextBox();
            label9 = new Label();
            uname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(change);
            panel1.Controls.Add(gender);
            panel1.Controls.Add(time);
            panel1.Controls.Add(upass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(uemail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(uphone);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(uname);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 566);
            panel1.TabIndex = 0;
            // 
            // change
            // 
            change.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            change.Location = new Point(478, 436);
            change.Margin = new Padding(2, 2, 2, 2);
            change.Name = "change";
            change.Size = new Size(90, 30);
            change.TabIndex = 27;
            change.Text = "Change";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            gender.Location = new Point(288, 249);
            gender.Margin = new Padding(2, 2, 2, 2);
            gender.Name = "gender";
            gender.Size = new Size(172, 25);
            gender.TabIndex = 26;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            time.ForeColor = Color.White;
            time.Location = new Point(237, 101);
            time.Margin = new Padding(2, 0, 2, 0);
            time.Name = "time";
            time.Size = new Size(59, 22);
            time.TabIndex = 20;
            time.Text = "label4";
            // 
            // upass
            // 
            upass.Location = new Point(288, 373);
            upass.Margin = new Padding(2, 2, 2, 2);
            upass.Name = "upass";
            upass.Size = new Size(172, 23);
            upass.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 148);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 30);
            label3.TabIndex = 12;
            label3.Text = "Basic info";
            // 
            // uemail
            // 
            uemail.Location = new Point(288, 334);
            uemail.Margin = new Padding(2, 2, 2, 2);
            uemail.Name = "uemail";
            uemail.Size = new Size(172, 23);
            uemail.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 11;
            label2.Text = "Total hours";
            // 
            // uphone
            // 
            uphone.Location = new Point(288, 290);
            uphone.Margin = new Padding(2, 2, 2, 2);
            uphone.Name = "uphone";
            uphone.Size = new Size(172, 23);
            uphone.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(63, 370);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(110, 25);
            label9.TabIndex = 10;
            label9.Text = "Password :";
            // 
            // uname
            // 
            uname.Location = new Point(288, 210);
            uname.Margin = new Padding(2, 2, 2, 2);
            uname.Name = "uname";
            uname.Size = new Size(172, 23);
            uname.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(99, 334);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(72, 25);
            label8.TabIndex = 9;
            label8.Text = "Email :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(90, 290);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 25);
            label7.TabIndex = 8;
            label7.Text = "Phone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(83, 249);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 7;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(93, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 6;
            label5.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 42);
            label1.TabIndex = 0;
            label1.Text = "Personal info";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Userinfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Userinfo";
            Size = new Size(615, 566);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label time;
        private ComboBox gender;
        private TextBox uemail;
        private TextBox uphone;
        private TextBox uname;
        private ContextMenuStrip contextMenuStrip1;
        public TextBox upass;
        private Button change;
    }
}
