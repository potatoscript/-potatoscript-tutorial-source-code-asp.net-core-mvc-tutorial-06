using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Project
    {
        public List<Project> project = new List<Project>();

        public string Id { get; set; }
        public string Text { get; set; }

        public int ProjectId { get; set; }

        public string title { get; set; }
        public string owner { get; set; }

        public string duedate { get; set; }

    }
}
