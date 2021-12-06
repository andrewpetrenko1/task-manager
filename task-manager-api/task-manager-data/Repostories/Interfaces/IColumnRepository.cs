using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_data.Models;

namespace task_manager_data.Repostories.Interfaces
{
    public interface IColumnRepository
    {
        IEnumerable<Column> GetProjectsColumns(int projectId);
        Column GetColumn(int id);
        Column UpdateColumn(Column column);
        bool DeleteColumn(int id);
    }
}
