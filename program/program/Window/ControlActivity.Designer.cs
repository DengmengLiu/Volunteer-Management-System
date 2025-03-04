namespace program.Window
{
    partial class Form2
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
            buttonSub = new Button();
            panel1 = new Panel();
            dateTimeET = new DateTimePicker();
            dateTimeST = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDes = new TextBox();
            textBoxNP = new TextBox();
            textBoxPlace = new TextBox();
            textBoxName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSub
            // 
            buttonSub.BackColor = Color.FromArgb(128, 128, 255);
            buttonSub.FlatAppearance.BorderSize = 0;
            buttonSub.FlatStyle = FlatStyle.Flat;
            buttonSub.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSub.ForeColor = Color.White;
            buttonSub.Location = new Point(170, 300);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(202, 48);
            buttonSub.TabIndex = 0;
            buttonSub.Text = "Submit";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimeET);
            panel1.Controls.Add(dateTimeST);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxDes);
            panel1.Controls.Add(textBoxNP);
            panel1.Controls.Add(textBoxPlace);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(buttonSub);
            panel1.Location = new Point(41, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 370);
            panel1.TabIndex = 2;
            // 
            // dateTimeET
            // 
            dateTimeET.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimeET.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeET.Format = DateTimePickerFormat.Custom;
            dateTimeET.Location = new Point(354, 123);
            dateTimeET.Name = "dateTimeET";
            dateTimeET.Size = new Size(148, 27);
            dateTimeET.TabIndex = 17;
            dateTimeET.Value = new DateTime(2023, 10, 12, 0, 0, 0, 0);
            // 
            // dateTimeST
            // 
            dateTimeST.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimeST.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeST.Format = DateTimePickerFormat.Custom;
            dateTimeST.Location = new Point(106, 121);
            dateTimeST.Name = "dateTimeST";
            dateTimeST.Size = new Size(148, 27);
            dateTimeST.TabIndex = 16;
            dateTimeST.Value = new DateTime(2023, 10, 12, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(27, 254);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 15;
            label7.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(269, 54);
            label5.Name = "label5";
            label5.Size = new Size(111, 21);
            label5.TabIndex = 13;
            label5.Text = "No of People";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(260, 123);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 12;
            label4.Text = "End Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(16, 123);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 11;
            label3.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(54, 190);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 10;
            label2.Text = "Place";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 54);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 9;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // textBoxDes
            // 
            textBoxDes.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDes.Location = new Point(129, 248);
            textBoxDes.Name = "textBoxDes";
            textBoxDes.Size = new Size(364, 32);
            textBoxDes.TabIndex = 8;
            // 
            // textBoxNP
            // 
            textBoxNP.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNP.Location = new Point(386, 48);
            textBoxNP.Name = "textBoxNP";
            textBoxNP.Size = new Size(107, 32);
            textBoxNP.TabIndex = 7;
            // 
            // textBoxPlace
            // 
            textBoxPlace.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlace.Location = new Point(129, 184);
            textBoxPlace.Name = "textBoxPlace";
            textBoxPlace.Size = new Size(364, 32);
            textBoxPlace.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(106, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(139, 32);
            textBoxName.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(606, 457);
            Controls.Add(panel1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSub;
        private Panel panel1;
        private Label label1;
        public TextBox textBoxDes;
        public TextBox textBoxNP;
        public TextBox textBoxPlace;
        public TextBox textBoxName;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        public DateTimePicker dateTimeST;
        public DateTimePicker dateTimeET;
    }
}