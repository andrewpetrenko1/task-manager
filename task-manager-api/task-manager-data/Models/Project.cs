using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager_data.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripion { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
    }
}
