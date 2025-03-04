using Microsoft.Identity.Client.Extensions.Msal;
using program.Domain;

namespace program.Window
{
    public partial class ActivityDetailForm : Form
    {
        private bool isJoined = false;
        private bool isFaved = false;
        private bool isFull = false;
        private bool isInWait = false;
        private int aid, uid;
        private Activity act = new Activity();
        private UserActivity userActivity = new UserActivity();
        public ActivityDetailForm(int aid, int uid)
        {
            InitializeComponent();
            this.aid = aid;
            this.uid = uid;
            act = Activity.Read(aid);
            userActivity = UserActivity.Read(uid, aid);
            List<Activity> a = Activity.AllActivities();
            int index = -1;
            foreach (Activity activity in a)
            {
                if (activity.Id == aid)
                {
                    index = a.IndexOf(activity);
                }
            }
            if (index == -1)
            {
                this.Close();
            }

            // Update controls on the form to display activity information
            Id_text.Text = a[index].Id.ToString();
            Name_text.Text = a[index].Name.ToString();

            if (userActivity == null || userActivity.State == UserActivityStatus.NotComplete)
            {
                STime_text.Text = a[index].StartTime.ToString();
                ETime_text.Text = a[index].EndTime.ToString();
                Duration_text.Text = a[index].Duration.ToString("F2");
                Place_text.Text = a[index].Place.ToString();
                Des_text.Text = a[index].Description.ToString();
                Load += MyForm_Load;
            }
            else
            {
                Load += CompletedForm_Load;
            }


        }

        // Initialization operation when the form is loaded
        private void MyForm_Load(object sender, EventArgs e)
        {
            UserStatus();
            UpdateButtonState(isFaved, btnFavorite, "Favorite", Color.Gray, Color.DarkKhaki);

            if (!isJoined)
            {
                if (isFull)
                {
                    UpdateButtonState(isInWait, btnJoinin, "Add to Waitlist", Color.Gray, Color.Blue);
                    return;
                }
            }
            UpdateButtonState(isJoined, btnJoinin, "Join In", Color.Red, Color.DarkGreen);
        }

        private void CompletedForm_Load(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(Id_text);
            Controls.Add(Name_text);
            label5.Text = "Feedback:";
            Controls.Add(label5);
            textbox_feedback.Text = userActivity.Feedback;
            Controls.Add(textbox_feedback);
            Controls.Add(closebtn);
            Controls.Add(btnSub);

        }
        //Update the user's status, including whether they have joined, are favorites, the event is full, and whether they are on the waiting list
        private void UserStatus()
        {

            if (UserActivity.Read(uid, aid) != null)
            {
                isJoined = true;
            }
            else
            {
                isJoined = false;
            }

            if (act.JoinedPeople() >= act.NoPeople)
            {
                isFull = true;
            }
            else
            {
                isFull = false;
            }

            if (WaitList.Read(uid, aid) != null)
            {
                isInWait = true;
            }
            else
            {
                isInWait = false;
            }

            if (Favorite.Read(uid, aid) != null)
            {
                isFaved = true;
            }
            else
            {
                isFaved = false;
            }
        }

        //Update the status of the button according to the user's favorite and joined status
        private void UpdateButtonState(Boolean b, Button button, string str, Color cancelc, Color c)
        {
            if (b)
            {
                button.Text = "Cancel " + str;
                button.BackColor = cancelc;
            }
            else
            {
                button.Text = str;
                button.BackColor = c;
            }
        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The logic for the user to click the "Favorite" button
        private void btnFavorite_Click(object sender, EventArgs e)
        {

            if (isFaved)
            {
                Favorite.Delete(uid, aid);
                MessageBox.Show("Unfavorited", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Favorite.Create(new Favorite(uid, aid));
                MessageBox.Show("Favorited", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            UserStatus();
            UpdateButtonState(isFaved, btnFavorite, "Favorite", Color.Gray, Color.DarkKhaki);
        }

        private void Textbox_feedback_Click(object sender, EventArgs e)
        {
            userActivity.Feedback = textbox_feedback.Text;
            UserActivity.Update(userActivity);
            MessageBox.Show("Successed!");
            Close();
        }
        private void btnJoinin_Click(object sender, EventArgs e)
        {
            UserBtnControl();
        }

        // Handle the logic for users to join or cancel activities
        private void UserBtnControl()
        {
            if (isJoined)
            {
                UserActivity.Delete(uid, aid);
                Notification.Create(new Notification(uid, " Cancelled joined event " + Activity.Read(aid).Id + " " + Activity.Read(aid).Name, DateTime.Now));
                MessageBox.Show("Cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (isFull)
                {
                    if (isInWait)
                    {
                        WaitList.Delete(uid, aid);
                        Notification.Create(new Notification(uid, "Cancelled in Waitlist for " + Activity.Read(aid).Id + " " + Activity.Read(aid).Name, DateTime.Now));
                        MessageBox.Show("Cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        WaitList.Create(new WaitList(uid, aid));
                        Notification.Create(new Notification(uid, "Joined in Waitlist for " + Activity.Read(aid).Id + " " + Activity.Read(aid).Name, DateTime.Now));
                        MessageBox.Show("Added into Waitlist", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    UserStatus();
                    UpdateButtonState(isInWait, btnJoinin, "Add to Waitlist", Color.Gray, Color.Blue);
                    return;
                }
                else
                {
                    if (isInWait)
                    {
                        WaitList.Delete(uid, aid);
                    }
                    UserActivity.Create(new UserActivity(uid, aid, UserActivityStatus.NotComplete, "", DateTime.Now));
                    Notification.Create(new Notification(uid, "Joined event " + Activity.Read(aid).Id + " " + Activity.Read(aid).Name, DateTime.Now));
                    MessageBox.Show("Joined in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            UserStatus();
            UpdateButtonState(isJoined, btnJoinin, "Join In", Color.Red, Color.DarkGreen);

        }

    }
}

