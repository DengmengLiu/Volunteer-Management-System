namespace User1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            signup = new Button();
            log = new Button();
            panel4 = new Panel();
            pass = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            id = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            closebtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 51, 73);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 841);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(287, 422);
            label3.Name = "label3";
            label3.Size = new Size(139, 43);
            label3.TabIndex = 3;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 359);
            label2.Name = "label2";
            label2.Size = new Size(417, 43);
            label2.TabIndex = 2;
            label2.Text = "Volunteer Mangement";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(125, 285);
            label1.Name = "label1";
            label1.Size = new Size(301, 43);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(signup);
            panel2.Controls.Add(log);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(closebtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(448, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 841);
            panel2.TabIndex = 1;
            // 
            // signup
            // 
            signup.BackColor = Color.FromArgb(24, 30, 54);
            signup.FlatStyle = FlatStyle.Flat;
            signup.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            signup.ForeColor = Color.White;
            signup.Location = new Point(182, 531);
            signup.Name = "signup";
            signup.Size = new Size(149, 50);
            signup.TabIndex = 8;
            signup.Text = "SIGNUP";
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // log
            // 
            log.BackColor = Color.FromArgb(24, 30, 54);
            log.FlatStyle = FlatStyle.Flat;
            log.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            log.ForeColor = Color.White;
            log.Location = new Point(15, 531);
            log.Name = "log";
            log.Size = new Size(133, 50);
            log.TabIndex = 7;
            log.Text = "LOGIN";
            log.UseVisualStyleBackColor = false;
            log.Click += log_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(pass);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 92);
            panel4.TabIndex = 6;
            // 
            // pass
            // 
            pass.BackColor = SystemColors.Control;
            pass.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pass.ForeColor = Color.FromArgb(24, 40, 54);
            pass.Location = new Point(106, 26);
            pass.Name = "pass";
            pass.Size = new Size(628, 47);
            pass.TabIndex = 6;
            pass.UseSystemPasswordChar = true;
            pass.Click += textBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox4_Click;
            pictureBox3.MouseDown += pictureBox4_MouseDown;
            pictureBox3.MouseUp += pictureBox4_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(id);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 89);
            panel3.TabIndex = 5;
            // 
            // id
            // 
            id.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            id.ForeColor = Color.FromArgb(24, 40, 54);
            id.Location = new Point(106, 26);
            id.Name = "id";
            id.Size = new Size(628, 47);
            id.TabIndex = 5;
            id.Click += textBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(24, 40, 54);
            label4.Location = new Point(26, 183);
            label4.Name = "label4";
            label4.Size = new Size(406, 43);
            label4.TabIndex = 4;
            label4.Text = "Login to your account";
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.Transparent;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            closebtn.ForeColor = Color.FromArgb(24, 30, 54);
            closebtn.Location = new Point(798, 3);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 0;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 841);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button closebtn;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox id;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox pass;
        private Button log;
        private Button signup;
    }
}