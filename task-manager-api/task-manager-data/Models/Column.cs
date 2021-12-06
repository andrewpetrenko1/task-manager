using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager_data.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public List<TaskModel> Tasks { get; set; } = new List<TaskModel>();
    }
}
