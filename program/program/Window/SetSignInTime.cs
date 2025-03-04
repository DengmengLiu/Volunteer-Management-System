using program.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program.Window
{
    public partial class SetSignInTime : Form
    {
        public int uid;
        public int aid;
        public DateTime startTime;
        public DateTime endTime;
        AdministratorFunction function = new AdministratorFunction();
        public SetSignInTime()
        {
            InitializeComponent();
        }
        //Set the check-in time
        private void buttonSub_Click(object sender, EventArgs e)
        {
            DateTime signTime = SignInTime.Value;
            if ((signTime >= startTime) && (signTime <= endTime))
            {
                function.SetSignInTime(signTime, uid, aid);
                MessageBox.Show("success！please reopen the page to refresh the data", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("please type right time", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
