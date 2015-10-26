using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnx.Antlr.Post.Listeners.Models
{
    public class PostData
    {
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
        public Location Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsRecurring { get; set; }
    }
}
