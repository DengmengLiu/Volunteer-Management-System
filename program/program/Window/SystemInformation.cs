using program.Tools;
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
using static WinFormAnimation.AnimationFunctions;

namespace program.Window
{
    public partial class SystemInformation : Form
    {
        UserFunction function = new UserFunction();
        public SystemInformation()
        {
            InitializeComponent();
        }
        //Deletes the selected notification
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex >= 0) 
            {
                
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
                function.DeleteNotification(id);
                MessageBox.Show("delete success！please reopen to fresh the page", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
