namespace program.Window
{
    partial class AdministratorPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button7 = new Button();
            button4 = new Button();
            button3 = new Button();
            BUpdate = new Button();
            BAddActivity = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            placeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noPeopleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BEdit = new DataGridViewButtonColumn();
            DelButton = new DataGridViewButtonColumn();
            activityBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            dataGridViewName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Authority = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            userBindingSource = new BindingSource(components);
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ActivityId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(BUpdate);
            panel1.Controls.Add(BAddActivity);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 660);
            panel1.TabIndex = 1;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Top;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.FromArgb(0, 126, 249);
            button7.ImageAlign = ContentAlignment.MiddleRight;
            button7.Location = new Point(0, 376);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(190, 71);
            button7.TabIndex = 7;
            button7.Text = "User activity check-in";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(0, 126, 249);
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(0, 314);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(190, 62);
            button4.TabIndex = 4;
            button4.Text = "Update User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(0, 126, 249);
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(0, 254);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(190, 60);
            button3.TabIndex = 3;
            button3.Text = "Add User";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BUpdate
            // 
            BUpdate.Cursor = Cursors.Hand;
            BUpdate.Dock = DockStyle.Top;
            BUpdate.FlatStyle = FlatStyle.Flat;
            BUpdate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BUpdate.ForeColor = Color.FromArgb(0, 126, 249);
            BUpdate.ImageAlign = ContentAlignment.MiddleRight;
            BUpdate.Location = new Point(0, 191);
            BUpdate.Margin = new Padding(2);
            BUpdate.Name = "BUpdate";
            BUpdate.Size = new Size(190, 63);
            BUpdate.TabIndex = 2;
            BUpdate.Text = "Update Activity";
            BUpdate.UseVisualStyleBackColor = true;
            BUpdate.Click += BUpdate_Click;
            // 
            // BAddActivity
            // 
            BAddActivity.Cursor = Cursors.Hand;
            BAddActivity.Dock = DockStyle.Top;
            BAddActivity.FlatStyle = FlatStyle.Flat;
            BAddActivity.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BAddActivity.ForeColor = Color.FromArgb(0, 126, 249);
            BAddActivity.ImageAlign = ContentAlignment.MiddleRight;
            BAddActivity.Location = new Point(0, 128);
            BAddActivity.Margin = new Padding(2);
            BAddActivity.Name = "BAddActivity";
            BAddActivity.Size = new Size(190, 63);
            BAddActivity.TabIndex = 1;
            BAddActivity.Text = "Add Activity";
            BAddActivity.UseVisualStyleBackColor = true;
            BAddActivity.Click += EAdd;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 128);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(50, 103);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_11;
            pictureBox1.Location = new Point(50, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, id, descriptionDataGridViewTextBoxColumn, startTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn, placeDataGridViewTextBoxColumn, noPeopleDataGridViewTextBoxColumn, BEdit, DelButton });
            dataGridView1.DataSource = activityBindingSource;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(204, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(821, 607);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle1.BackColor = Color.White;
            nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // id
            // 
            id.DataPropertyName = "Id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            descriptionDataGridViewTextBoxColumn.Width = 180;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            startTimeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            startTimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            endTimeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            endTimeDataGridViewTextBoxColumn.Width = 110;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            placeDataGridViewTextBoxColumn.HeaderText = "Place";
            placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            placeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            placeDataGridViewTextBoxColumn.Width = 130;
            // 
            // noPeopleDataGridViewTextBoxColumn
            // 
            noPeopleDataGridViewTextBoxColumn.DataPropertyName = "NoPeople";
            noPeopleDataGridViewTextBoxColumn.HeaderText = "People";
            noPeopleDataGridViewTextBoxColumn.Name = "noPeopleDataGridViewTextBoxColumn";
            noPeopleDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            noPeopleDataGridViewTextBoxColumn.Width = 50;
            // 
            // BEdit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            BEdit.DefaultCellStyle = dataGridViewCellStyle2;
            BEdit.FlatStyle = FlatStyle.Flat;
            BEdit.HeaderText = "";
            BEdit.Name = "BEdit";
            BEdit.Text = "Edit";
            BEdit.UseColumnTextForButtonValue = true;
            BEdit.Width = 80;
            // 
            // DelButton
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            DelButton.DefaultCellStyle = dataGridViewCellStyle3;
            DelButton.FlatStyle = FlatStyle.Flat;
            DelButton.HeaderText = "";
            DelButton.Name = "DelButton";
            DelButton.Text = "Delete";
            DelButton.UseColumnTextForButtonValue = true;
            DelButton.Width = 80;
            // 
            // activityBindingSource
            // 
            activityBindingSource.DataSource = typeof(Domain.Activity);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewName, Password, Authority, Email, Phone, Sex, UserId, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            dataGridView2.DataSource = userBindingSource;
            dataGridView2.GridColor = SystemColors.ActiveCaption;
            dataGridView2.Location = new Point(204, 41);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 50;
            dataGridView2.RowTemplate.ReadOnly = true;
            dataGridView2.Size = new Size(821, 607);
            dataGridView2.TabIndex = 2;
            dataGridView2.Visible = false;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewName
            // 
            dataGridViewName.DataPropertyName = "Name";
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewName.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewName.HeaderText = "Name";
            dataGridViewName.Name = "dataGridViewName";
            dataGridViewName.Resizable = DataGridViewTriState.True;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.Width = 120;
            // 
            // Authority
            // 
            Authority.DataPropertyName = "Authority";
            Authority.HeaderText = "Authority";
            Authority.Name = "Authority";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 140;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.Width = 120;
            // 
            // Sex
            // 
            Sex.DataPropertyName = "Sex";
            Sex.HeaderText = "Sex";
            Sex.Name = "Sex";
            Sex.Width = 80;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "Id";
            UserId.HeaderText = "id";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Visible = false;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewButtonColumn1.FlatStyle = FlatStyle.Flat;
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Text = "Edit";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 80;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewButtonColumn2.FlatStyle = FlatStyle.Flat;
            dataGridViewButtonColumn2.HeaderText = "";
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.Text = "Delete";
            dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn2.Width = 80;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Domain.User);
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, ActivityId, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewButtonColumn3 });
            dataGridView3.DataSource = activityBindingSource;
            dataGridView3.GridColor = SystemColors.ActiveCaption;
            dataGridView3.Location = new Point(204, 41);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowTemplate.Height = 50;
            dataGridView3.RowTemplate.ReadOnly = true;
            dataGridView3.Size = new Size(821, 607);
            dataGridView3.TabIndex = 3;
            dataGridView3.Visible = false;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // ActivityId
            // 
            ActivityId.DataPropertyName = "Id";
            ActivityId.HeaderText = "id";
            ActivityId.Name = "ActivityId";
            ActivityId.ReadOnly = true;
            ActivityId.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            dataGridViewTextBoxColumn3.HeaderText = "Description";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            dataGridViewTextBoxColumn4.HeaderText = "StartTime";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "EndTime";
            dataGridViewTextBoxColumn5.HeaderText = "EndTime";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Place";
            dataGridViewTextBoxColumn6.HeaderText = "Place";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn6.Width = 160;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "NoPeople";
            dataGridViewTextBoxColumn7.HeaderText = "People";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle8.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewButtonColumn3.FlatStyle = FlatStyle.Flat;
            dataGridViewButtonColumn3.HeaderText = "";
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Text = "Sign in";
            dataGridViewButtonColumn3.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn3.Width = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(422, 0);
            label2.Name = "label2";
            label2.Size = new Size(319, 35);
            label2.TabIndex = 4;
            label2.Text = "Welcome,Administrator";
            label2.Click += label2_Click;
            // 
            // AdministratorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1037, 660);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView3);
            Name = "AdministratorPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Volunteer management system";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)activityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button BUpdate;
        private Button BAddActivity;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private BindingSource activityBindingSource;
        private DataGridView dataGridView2;
        private BindingSource userBindingSource;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noPeopleDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn BEdit;
        private DataGridViewButtonColumn DelButton;
        private DataGridViewTextBoxColumn dataGridViewName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Authority;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ActivityId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private Label label2;
    }
}