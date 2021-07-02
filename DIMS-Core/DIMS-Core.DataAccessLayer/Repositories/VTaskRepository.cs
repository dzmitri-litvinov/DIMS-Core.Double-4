using System.Linq;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    class VTaskRepository : IReadOnlyRepository<VTask>
    {
        private readonly DimsCoreContext _context;

        public VTaskRepository(DimsCoreContext context)
        {
            _context = context;
        }

        public IQueryable<VTask> GetAll()
        {
            return _context.VTasks.AsNoTracking();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
