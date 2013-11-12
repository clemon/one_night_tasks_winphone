using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneNightTasks.Models
{
    public class Job
    {
        public string Date { get; set; }
        public bool Is_live { get; set; }
        public string Client { get; set; }
        public string description { get; set; }
        public string Owner_name { get; set; }
        public string Title { get; set; }
        public long Price { get; set; }
        public long lat { get; set; }
        public long lng { get; set; }
    }
}
