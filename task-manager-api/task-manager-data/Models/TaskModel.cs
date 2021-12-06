using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager_data.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public int ColumnId { get; set; }
        public Column Column { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
