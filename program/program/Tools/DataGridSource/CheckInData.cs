using program.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.Tools.DataGridSource
{
    public class CheckInData
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public int ActivityId { get; set; }
        public UserActivityStatus State { get; set; }
        public string Feedback { get; set; }
        public DateTime? SignInTime { get; set; }
    }
}
