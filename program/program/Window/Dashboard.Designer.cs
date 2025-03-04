using program.Domain;

namespace User1
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            favo = new Button();
            button3 = new Button();
            button2 = new Button();
            userinfo = new Button();
            panel2 = new Panel();
            name = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            closebtn = new Button();
            main = new Panel();
            dashtxt = new Label();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            lab_totalVor = new Label();
            label4 = new Label();
            panel7 = new Panel();
            pictureBox3 = new PictureBox();
            lab_totalAct = new Label();
            label6 = new Label();
            btn_search = new Button();
            pictureBox4 = new PictureBox();
            textBox_search = new TextBox();
            panel_datagrid = new Panel();
            act_datagrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            durationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activityBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            main.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_datagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)act_datagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(favo);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(userinfo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 666);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Top;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(0, 126, 249);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(0, 517);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(207, 58);
            button7.TabIndex = 7;
            button7.Text = "System Info";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Top;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.FromArgb(0, 126, 249);
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(0, 459);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(207, 58);
            button6.TabIndex = 6;
            button6.Text = "Waitlist";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(0, 126, 249);
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(0, 401);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(207, 58);
            button5.TabIndex = 5;
            button5.Text = "Joined Activites";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // favo
            // 
            favo.Cursor = Cursors.Hand;
            favo.Dock = DockStyle.Top;
            favo.FlatStyle = FlatStyle.Flat;
            favo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            favo.ForeColor = Color.FromArgb(0, 126, 249);
            favo.Image = (Image)resources.GetObject("favo.Image");
            favo.ImageAlign = ContentAlignment.MiddleRight;
            favo.Location = new Point(0, 343);
            favo.Margin = new Padding(2);
            favo.Name = "favo";
            favo.Size = new Size(207, 58);
            favo.TabIndex = 4;
            favo.Text = "Favorites";
            favo.UseVisualStyleBackColor = true;
            favo.Click += favo_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(0, 285);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(207, 58);
            button3.TabIndex = 3;
            button3.Text = "Completed activities";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 227);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(207, 58);
            button2.TabIndex = 2;
            button2.Text = "Activities";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userinfo
            // 
            userinfo.Cursor = Cursors.Hand;
            userinfo.Dock = DockStyle.Top;
            userinfo.FlatStyle = FlatStyle.Flat;
            userinfo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userinfo.ForeColor = Color.FromArgb(0, 126, 249);
            userinfo.Image = (Image)resources.GetObject("userinfo.Image");
            userinfo.ImageAlign = ContentAlignment.MiddleRight;
            userinfo.Location = new Point(0, 169);
            userinfo.Margin = new Padding(2);
            userinfo.Name = "userinfo";
            userinfo.Size = new Size(207, 58);
            userinfo.TabIndex = 1;
            userinfo.Text = "User Info";
            userinfo.UseVisualStyleBackColor = true;
            userinfo.Click += userinfo_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(name);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 169);
            panel2.TabIndex = 0;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            name.ForeColor = Color.FromArgb(0, 126, 249);
            name.Location = new Point(109, 121);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(101, 25);
            name.TabIndex = 2;
            name.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(15, 121);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = program.Properties.Resources.Untitled_11;
            pictureBox1.Location = new Point(57, 15);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.Transparent;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point);
            closebtn.ForeColor = Color.White;
            closebtn.Location = new Point(861, 0);
            closebtn.Margin = new Padding(2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(55, 60);
            closebtn.TabIndex = 6;
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // main
            // 
            main.Controls.Add(dashtxt);
            main.Controls.Add(panel5);
            main.Controls.Add(panel7);
            main.Dock = DockStyle.Right;
            main.Location = new Point(207, 0);
            main.Margin = new Padding(2);
            main.Name = "main";
            main.Size = new Size(703, 666);
            main.TabIndex = 7;
            // 
            // dashtxt
            // 
            dashtxt.AutoSize = true;
            dashtxt.Font = new Font("Microsoft YaHei UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dashtxt.ForeColor = Color.FromArgb(158, 161, 176);
            dashtxt.Location = new Point(10, 19);
            dashtxt.Margin = new Padding(2, 0, 2, 0);
            dashtxt.Name = "dashtxt";
            dashtxt.Size = new Size(202, 46);
            dashtxt.TabIndex = 5;
            dashtxt.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(lab_totalVor);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(77, 396);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(534, 179);
            panel5.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(395, 25);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lab_totalVor
            // 
            lab_totalVor.AutoSize = true;
            lab_totalVor.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lab_totalVor.ForeColor = Color.FromArgb(50, 226, 178);
            lab_totalVor.Location = new Point(186, 82);
            lab_totalVor.Margin = new Padding(2, 0, 2, 0);
            lab_totalVor.Name = "lab_totalVor";
            lab_totalVor.Size = new Size(0, 57);
            lab_totalVor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(2, 15);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(205, 45);
            label4.TabIndex = 0;
            label4.Text = "Volunteers";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(pictureBox3);
            panel7.Controls.Add(lab_totalAct);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(79, 154);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(532, 179);
            panel7.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(393, 28);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 125);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lab_totalAct
            // 
            lab_totalAct.AutoSize = true;
            lab_totalAct.Font = new Font("Microsoft YaHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            lab_totalAct.ForeColor = Color.FromArgb(0, 126, 249);
            lab_totalAct.Location = new Point(184, 74);
            lab_totalAct.Margin = new Padding(2, 0, 2, 0);
            lab_totalAct.Name = "lab_totalAct";
            lab_totalAct.Size = new Size(0, 57);
            lab_totalAct.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 15);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 45);
            label6.TabIndex = 2;
            label6.Text = "Activities";
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.DarkBlue;
            btn_search.Location = new Point(460, 30);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 27);
            btn_search.TabIndex = 11;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = program.Properties.Resources.transparent_magnifying_glass_icon_search_icon_justice_elements_5feb4e9da86361_3383573116092566056897;
            pictureBox4.Location = new Point(200, 19);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(250, 30);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(200, 27);
            textBox_search.TabIndex = 10;
            // 
            // panel_datagrid
            // 
            panel_datagrid.Controls.Add(act_datagrid);
            panel_datagrid.Location = new Point(10, 70);
            panel_datagrid.Name = "panel_datagrid";
            panel_datagrid.Size = new Size(600, 425);
            panel_datagrid.TabIndex = 11;
            // 
            // act_datagrid
            // 
            act_datagrid.AllowUserToAddRows = false;
            act_datagrid.AllowUserToDeleteRows = false;
            act_datagrid.AllowUserToOrderColumns = true;
            act_datagrid.AutoGenerateColumns = false;
            act_datagrid.ColumnHeadersHeight = 29;
            act_datagrid.Columns.AddRange(new DataGridViewColumn[] { ID, nameDataGridViewTextBoxColumn, placeDataGridViewTextBoxColumn, durationDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            act_datagrid.DataSource = activityBindingSource;
            act_datagrid.Dock = DockStyle.Fill;
            act_datagrid.Location = new Point(0, 0);
            act_datagrid.Name = "act_datagrid";
            act_datagrid.ReadOnly = true;
            act_datagrid.RowHeadersWidth = 4;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            act_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            act_datagrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            act_datagrid.RowTemplate.Height = 50;
            act_datagrid.RowTemplate.Resizable = DataGridViewTriState.True;
            act_datagrid.Size = new Size(600, 425);
            act_datagrid.TabIndex = 10;
            act_datagrid.CellClick += act_datagrid_CellClick;
            act_datagrid.CellFormatting += act_datagrid_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            placeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            placeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            placeDataGridViewTextBoxColumn.HeaderText = "Place";
            placeDataGridViewTextBoxColumn.MinimumWidth = 6;
            placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            placeDataGridViewTextBoxColumn.ReadOnly = true;
            placeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            durationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            durationDataGridViewTextBoxColumn.ReadOnly = true;
            durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            startTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            endTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityBindingSource
            // 
            activityBindingSource.DataSource = typeof(Activity);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(910, 666);
            Controls.Add(main);
            Controls.Add(closebtn);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            main.ResumeLayout(false);
            main.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_datagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)act_datagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button userinfo;
        private Label name;
        private Label label1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button favo;
        private Button button3;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button closebtn;
        private Panel main;
        private Panel panel6;
        private Label dashtxt;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Panel panel4;
        private Panel panel7;
        private PictureBox pictureBox3;
        private Label lab_totalAct;
        private Label lab_totalVor;
        private Label label6;
        private Panel panel_datagrid;
        private DataGridView act_datagrid;
        private BindingSource activityBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private TextBox textBox_search;
        private Button btn_search;
        private PictureBox pictureBox4;
    }
}