using program.Tools.DataGridSource;

namespace program.Window
{
    partial class ActivitySignIn
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
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feedbackDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            signInTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SignIn = new DataGridViewButtonColumn();
            checkInDataBindingSource = new BindingSource(components);
            administratorFunctionBindingSource1 = new BindingSource(components);
            administratorFunctionBindingSource = new BindingSource(components);
            userActivityBindingSource = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkInDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administratorFunctionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)administratorFunctionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userActivityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, activityIdDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn, feedbackDataGridViewTextBoxColumn, signInTimeDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, SignIn });
            dataGridView1.DataSource = checkInDataBindingSource;
            dataGridView1.Location = new Point(-1, -4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(503, 362);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activityIdDataGridViewTextBoxColumn
            // 
            activityIdDataGridViewTextBoxColumn.DataPropertyName = "ActivityId";
            activityIdDataGridViewTextBoxColumn.HeaderText = "ActivityId";
            activityIdDataGridViewTextBoxColumn.Name = "activityIdDataGridViewTextBoxColumn";
            activityIdDataGridViewTextBoxColumn.ReadOnly = true;
            activityIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feedbackDataGridViewTextBoxColumn
            // 
            feedbackDataGridViewTextBoxColumn.DataPropertyName = "Feedback";
            feedbackDataGridViewTextBoxColumn.HeaderText = "Feedback";
            feedbackDataGridViewTextBoxColumn.Name = "feedbackDataGridViewTextBoxColumn";
            feedbackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // signInTimeDataGridViewTextBoxColumn
            // 
            signInTimeDataGridViewTextBoxColumn.DataPropertyName = "SignInTime";
            signInTimeDataGridViewTextBoxColumn.HeaderText = "SignInTime";
            signInTimeDataGridViewTextBoxColumn.Name = "signInTimeDataGridViewTextBoxColumn";
            signInTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            userIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // SignIn
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            SignIn.DefaultCellStyle = dataGridViewCellStyle1;
            SignIn.FlatStyle = FlatStyle.Flat;
            SignIn.HeaderText = "";
            SignIn.Name = "SignIn";
            SignIn.ReadOnly = true;
            SignIn.Text = "SignIn";
            SignIn.UseColumnTextForButtonValue = true;
            // 
            // checkInDataBindingSource
            // 
            checkInDataBindingSource.DataSource = typeof(CheckInData);
            // 
            // administratorFunctionBindingSource1
            // 
            administratorFunctionBindingSource1.DataSource = typeof(Tools.AdministratorFunction);
            // 
            // administratorFunctionBindingSource
            // 
            administratorFunctionBindingSource.DataSource = typeof(Tools.AdministratorFunction);
            // 
            // userActivityBindingSource
            // 
            userActivityBindingSource.DataSource = typeof(Domain.UserActivity);
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Domain.User);
            // 
            // ActivitySignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(499, 356);
            Controls.Add(dataGridView1);
            Name = "ActivitySignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "activitySignIn";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkInDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)administratorFunctionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)administratorFunctionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userActivityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private BindingSource userActivityBindingSource;
        private BindingSource userBindingSource;
        private BindingSource administratorFunctionBindingSource;
        private BindingSource administratorFunctionBindingSource1;
        private BindingSource checkInDataBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn activityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feedbackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn signInTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn SignIn;
    }
}