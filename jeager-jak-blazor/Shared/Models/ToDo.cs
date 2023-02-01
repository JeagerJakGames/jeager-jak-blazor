using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeager_jak_blazor.Shared.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime DueByDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public List<Notes> Notes { get; set; }

    }
}
