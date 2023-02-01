using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeager_jak_blazor.Shared.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime EnteredDate { get; set; }
    }
}
