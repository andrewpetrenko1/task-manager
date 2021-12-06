using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_manager_data.Models;
using task_manager_data.Repostories.Interfaces;

namespace task_manager_data.Repostories
{
    public class ColumnRepository : IColumnRepository
    {
        private readonly ITaskManagerDbContext _context;
        public ColumnRepository(ITaskManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Column> GetProjectsColumns(int projectId) => _context.Columns.Where(c => c.ProjectId == projectId).ToList();

        public Column GetColumn(int id) => _context.Columns.FirstOrDefault(c => c.Id == id);

        public Column UpdateColumn(Column column)
        {
            _context.Columns.Update(column);
            _context.SaveChanges();
            return column;
        }

        public bool DeleteColumn(int id)
        {
            _context.Columns.Remove(_context.Columns.Find(id));
            if (_context.SaveChanges() > 0)
                return true;

            return false;
        }
    }
}
