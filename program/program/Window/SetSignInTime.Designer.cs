namespace program.Window
{
    partial class SetSignInTime
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
            SignInTime = new DateTimePicker();
            buttonSub = new Button();
            SuspendLayout();
            // 
            // SignInTime
            // 
            SignInTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            SignInTime.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SignInTime.Format = DateTimePickerFormat.Custom;
            SignInTime.Location = new Point(120, 131);
            SignInTime.Name = "SignInTime";
            SignInTime.Size = new Size(258, 38);
            SignInTime.TabIndex = 17;
            SignInTime.Value = new DateTime(2023, 10, 12, 0, 0, 0, 0);
            // 
            // buttonSub
            // 
            buttonSub.BackColor = Color.FromArgb(128, 128, 255);
            buttonSub.FlatAppearance.BorderSize = 0;
            buttonSub.FlatStyle = FlatStyle.Flat;
            buttonSub.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSub.ForeColor = Color.White;
            buttonSub.Location = new Point(142, 250);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(202, 48);
            buttonSub.TabIndex = 18;
            buttonSub.Text = "Submit";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // SetSignInTime
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(486, 382);
            Controls.Add(buttonSub);
            Controls.Add(SignInTime);
            Name = "SetSignInTime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SetSignInTime";
            ResumeLayout(false);
        }

        #endregion

        public DateTimePicker SignInTime;
        private Button buttonSub;
    }
}