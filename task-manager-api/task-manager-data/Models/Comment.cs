using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager_data.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int TaskId { get; set; }
        public TaskModel Task { get; set; }
    }
}
