using Microsoft.EntityFrameworkCore.Metadata.Internal;
using program.Tools.DataGridSource;
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
    public partial class ActivitySignIn : Form
    {
        public DateTime startTime;
        public DateTime endTime;

        public ActivitySignIn()
        {
            InitializeComponent();
        }

        //Check in to the selected user
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)  
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int uid = Convert.ToInt32(row.Cells["userIdDataGridViewTextBoxColumn"].Value);
                int aid = Convert.ToInt32(row.Cells["activityIdDataGridViewTextBoxColumn"].Value);
                SetSignInTime setSignInTime = new SetSignInTime();
                setSignInTime.aid = aid;
                setSignInTime.uid = uid;
                setSignInTime.startTime = startTime;
                setSignInTime.endTime = endTime;
                setSignInTime.Show();
            }
        }
    }
}
