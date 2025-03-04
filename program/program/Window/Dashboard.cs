using program.Domain;
using program.Tools;
using program.Window;

namespace User1
{
    public partial class Dashboard : Form
    {
        private string username;
        private int userId;
        UserFunction function = new UserFunction();


        public Dashboard(int userId, string username)
        {
            InitializeComponent();
            this.username = username;
            this.userId = userId;
            name.Text = username;// Display the username in the UI
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userinfo_Click(object sender, EventArgs e)
        {

            Userinfo userinfoControl = new Userinfo(userId);
            main.Controls.Clear();
            main.Controls.Add(userinfoControl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            program.Window.SystemInformation systemInformation = new program.Window.SystemInformation();
            systemInformation.dataGridView1.DataSource = function.GetNotifications(userId);
            systemInformation.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivityPanel("All Activities");
            // Load and display all activities in the data grid
            List<Activity> list = Activity.AllActivities();
            act_datagrid.DataSource = list;
        }

        private void act_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected activity's ID and display its details in a separate form
                DataGridViewRow selectedRow = act_datagrid.Rows[e.RowIndex];
                int actId = (int)selectedRow.Cells["ID"].Value;
                ActivityDetailForm detailForm = new ActivityDetailForm(actId, userId);
                detailForm.ShowDialog();
            }
        }

        private void act_datagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value is double duration)
                {
                    // Format the activity duration to display two decimal places
                    e.Value = duration.ToString("0.00");
                    e.FormattingApplied = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivityPanel("Completed");
            List<Activity> list = UserActivity.GetActivities(userId, UserActivityStatus.SignedIn);
            act_datagrid.DataSource = list;
        }

        private void favo_Click(object sender, EventArgs e)
        {
            ActivityPanel("Favorites");
            List<Activity> list = Favorite.GetFavoriteActivities(userId);
            act_datagrid.DataSource = list;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivityPanel("Joined");
            List<Activity> list = UserActivity.GetActivities(userId, UserActivityStatus.NotComplete);
            //list.AddRange(UserActivity.GetActivities(userId, UserActivityStatus.SignedIn));
            act_datagrid.DataSource = list;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivityPanel("WaitList");
            List<Activity> list = WaitList.GetActivities(userId);
            act_datagrid.DataSource = list;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Activity> list = Activity.SearchActivities(textBox_search.Text);

            act_datagrid.DataSource = list;
            act_datagrid.Refresh();
        }


        private void ActivityPanel(string title)
        {
            Controls.Add(main);
            main.Controls.Clear();
            dashtxt.Text = title;
            main.Controls.Add(btn_search);
            main.Controls.Add(pictureBox4);
            main.Controls.Add(textBox_search);
            main.Controls.Add(dashtxt);
            //main.Controls.Add(closebtn);
            main.Controls.Add(panel_datagrid);

        }
    }
}
