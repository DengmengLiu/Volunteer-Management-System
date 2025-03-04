using program.Domain;

namespace program.Window
{
    partial class ActivityDetailForm
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
            closebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Name_text = new Label();
            Id_text = new Label();
            Place_text = new Label();
            Duration_text = new Label();
            STime_text = new Label();
            ETime_text = new Label();
            panel1 = new Panel();
            Des_text = new Label();
            btnFavorite = new Button();
            btnJoinin = new Button();
            lab_Hrs = new Label();
            labTo = new Label();
            label7 = new Label();
            textbox_feedback = new TextBox();
            btnSub = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.Transparent;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            closebtn.ForeColor = Color.White;
            closebtn.Location = new Point(746, -1);
            closebtn.Margin = new Padding(2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(55, 60);
            closebtn.TabIndex = 7;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(26, 96);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 8;
            label1.Text = "Activity No. :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 126, 249);
            label2.Location = new Point(27, 136);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 9;
            label2.Text = "Activity Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(27, 260);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 10;
            label3.Text = "Date and Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(27, 216);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 11;
            label4.Text = "Duration:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(27, 176);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 12;
            label5.Text = "Place:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 126, 249);
            label6.Location = new Point(27, 300);
            label6.Name = "label6";
            label6.Size = new Size(114, 25);
            label6.TabIndex = 13;
            label6.Text = "Description:";
            // 
            // Name_text
            // 
            Name_text.AutoSize = true;
            Name_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name_text.Location = new Point(205, 134);
            Name_text.Name = "Name_text";
            Name_text.Size = new Size(65, 27);
            Name_text.TabIndex = 14;
            Name_text.Text = "name";
            // 
            // Id_text
            // 
            Id_text.AutoSize = true;
            Id_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Id_text.Location = new Point(205, 94);
            Id_text.Name = "Id_text";
            Id_text.Size = new Size(30, 27);
            Id_text.TabIndex = 15;
            Id_text.Text = "id";
            // 
            // Place_text
            // 
            Place_text.AutoSize = true;
            Place_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Place_text.Location = new Point(205, 170);
            Place_text.Name = "Place_text";
            Place_text.Size = new Size(62, 27);
            Place_text.TabIndex = 18;
            Place_text.Text = "place";
            // 
            // Duration_text
            // 
            Duration_text.AutoSize = true;
            Duration_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Duration_text.Location = new Point(205, 214);
            Duration_text.Name = "Duration_text";
            Duration_text.Size = new Size(56, 27);
            Duration_text.TabIndex = 19;
            Duration_text.Text = "dura";
            // 
            // STime_text
            // 
            STime_text.AutoSize = true;
            STime_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            STime_text.Location = new Point(205, 258);
            STime_text.Name = "STime_text";
            STime_text.Size = new Size(63, 27);
            STime_text.TabIndex = 20;
            STime_text.Text = "stime";
            // 
            // ETime_text
            // 
            ETime_text.AutoSize = true;
            ETime_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ETime_text.Location = new Point(421, 258);
            ETime_text.Name = "ETime_text";
            ETime_text.Size = new Size(65, 27);
            ETime_text.TabIndex = 21;
            ETime_text.Text = "etime";
            // 
            // panel1
            // 
            panel1.Controls.Add(Des_text);
            panel1.Location = new Point(27, 328);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 98);
            panel1.TabIndex = 22;
            // 
            // Des_text
            // 
            Des_text.AutoSize = true;
            Des_text.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Des_text.Location = new Point(3, 7);
            Des_text.Name = "Des_text";
            Des_text.Size = new Size(45, 27);
            Des_text.TabIndex = 28;
            Des_text.Text = "des";
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(666, 328);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(122, 25);
            btnFavorite.TabIndex = 23;
            btnFavorite.Text = "button1";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnJoinin
            // 
            btnJoinin.BackgroundImageLayout = ImageLayout.None;
            btnJoinin.Location = new Point(634, 376);
            btnJoinin.Name = "btnJoinin";
            btnJoinin.Size = new Size(154, 50);
            btnJoinin.TabIndex = 24;
            btnJoinin.Text = "button2";
            btnJoinin.UseVisualStyleBackColor = true;
            btnJoinin.Click += btnJoinin_Click;
            // 
            // lab_Hrs
            // 
            lab_Hrs.AutoSize = true;
            lab_Hrs.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_Hrs.Location = new Point(256, 214);
            lab_Hrs.Name = "lab_Hrs";
            lab_Hrs.Size = new Size(44, 27);
            lab_Hrs.TabIndex = 25;
            lab_Hrs.Text = "Hrs";
            // 
            // labTo
            // 
            labTo.AutoSize = true;
            labTo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labTo.Location = new Point(394, 258);
            labTo.Name = "labTo";
            labTo.Size = new Size(27, 27);
            labTo.TabIndex = 26;
            labTo.Text = "~";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(158, 161, 176);
            label7.Location = new Point(256, 11);
            label7.Name = "label7";
            label7.Size = new Size(266, 48);
            label7.TabIndex = 27;
            label7.Text = "Activity Details";
            // 
            // textbox_feedback
            // 
            textbox_feedback.Location = new Point(40, 160);
            textbox_feedback.Multiline = true;
            textbox_feedback.Name = "textbox_feedback";
            textbox_feedback.Size = new Size(612, 100);
            textbox_feedback.TabIndex = 10;
            
            
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(128, 128, 255);
            btnSub.FlatAppearance.BorderSize = 0;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.ForeColor = Color.White;
            btnSub.Location = new Point(256, 280);
            btnSub.Size = new Size(202, 48);
            btnSub.TabIndex = 0;
            btnSub.Text = "Submit";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += Textbox_feedback_Click;
            // 
            // ActivityDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(labTo);
            Controls.Add(lab_Hrs);
            Controls.Add(btnJoinin);
            Controls.Add(btnFavorite);
            Controls.Add(panel1);
            Controls.Add(ETime_text);
            Controls.Add(STime_text);
            Controls.Add(Duration_text);
            Controls.Add(Place_text);
            Controls.Add(Id_text);
            Controls.Add(Name_text);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closebtn);
            
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ActivityDetailForm";
            Text = "ActivityDetailForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Name_text;
        private Label Id_text;
        private Label Place_text;
        private Label Duration_text;
        private Label STime_text;
        private Label ETime_text;
        private Panel panel1;
        private Button btnFavorite;
        private Button btnJoinin;
        private Label lab_Hrs;
        private Label labTo;
        private Label label7;
        private Label Des_text;
        private TextBox textbox_feedback;
        private Button button1;
        private Button btnSub;
    }
}