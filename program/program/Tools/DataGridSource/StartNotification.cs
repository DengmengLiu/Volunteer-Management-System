using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Tools.DataGridSource
{
    public class StartNotification
    {
        public string ActivityName { get; set; }
        public string Place { get; set; }
        public DateTime StartTime { get; set; }
        public int UId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
