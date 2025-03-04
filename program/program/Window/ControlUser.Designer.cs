namespace program.Window
{
    partial class Form3
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
            panel1 = new Panel();
            checkBox_admin = new CheckBox();
            panelSex = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            buttonSub = new Button();
            radioButton4 = new RadioButton();
            panel1.SuspendLayout();
            panelSex.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox_admin);
            panel1.Controls.Add(panelSex);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxPhone);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(buttonSub);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 435);
            panel1.TabIndex = 3;
            // 
            // checkBox_admin
            // 
            checkBox_admin.AutoSize = true;
            checkBox_admin.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox_admin.ForeColor = SystemColors.ButtonFace;
            checkBox_admin.Location = new Point(381, 373);
            checkBox_admin.Name = "checkBox_admin";
            checkBox_admin.Size = new Size(214, 39);
            checkBox_admin.TabIndex = 19;
            checkBox_admin.Text = "Administrator";
            checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // panelSex
            // 
            panelSex.Controls.Add(radioButton3);
            panelSex.Controls.Add(radioButton2);
            panelSex.Controls.Add(radioButton1);
            panelSex.Location = new Point(131, 267);
            panelSex.Margin = new Padding(3, 4, 3, 4);
            panelSex.Name = "panelSex";
            panelSex.Size = new Size(423, 68);
            panelSex.TabIndex = 17;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(277, 19);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(102, 35);
            radioButton3.TabIndex = 18;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(134, 19);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 35);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(14, 19);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 35);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(31, 207);
            label7.Name = "label7";
            label7.Size = new Size(103, 27);
            label7.TabIndex = 15;
            label7.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(296, 64);
            label5.Name = "label5";
            label5.Size = new Size(72, 27);
            label5.TabIndex = 13;
            label5.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(71, 286);
            label3.Name = "label3";
            label3.Size = new Size(45, 27);
            label3.TabIndex = 11;
            label3.Text = "Sex";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(31, 134);
            label2.Name = "label2";
            label2.Size = new Size(63, 27);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(31, 64);
            label1.Name = "label1";
            label1.Size = new Size(69, 27);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(131, 200);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(431, 38);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(386, 56);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(177, 38);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(102, 127);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(461, 38);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(102, 56);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(158, 38);
            textBoxName.TabIndex = 1;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = Color.FromArgb(128, 128, 255);
            buttonSub.FlatAppearance.BorderSize = 0;
            buttonSub.FlatStyle = FlatStyle.Flat;
            buttonSub.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSub.ForeColor = Color.White;
            buttonSub.Location = new Point(131, 362);
            buttonSub.Margin = new Padding(3, 4, 3, 4);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(231, 56);
            buttonSub.TabIndex = 0;
            buttonSub.Text = "Submit";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(400, 374);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(213, 39);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "Administrator";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(631, 462);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSex.ResumeLayout(false);
            panelSex.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox textBoxPassword;
        public TextBox textBoxPhone;
        public TextBox textBoxEmail;
        public TextBox textBoxName;
        private Button buttonSub;
        public RadioButton radioButton1;
        public Panel panelSex;
        public RadioButton radioButton3;
        public RadioButton radioButton2;
        public RadioButton radioButton4;
        private CheckBox checkBox_admin;
    }
}