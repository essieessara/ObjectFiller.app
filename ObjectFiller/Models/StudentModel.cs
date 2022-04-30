using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFiller.Models
{
    public record StudentModel
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set;}
        public int StudentAge { get; set;}
        public string StudentEmail { get; set; }
        public string StudentPhone { get; set; }
    }
}
