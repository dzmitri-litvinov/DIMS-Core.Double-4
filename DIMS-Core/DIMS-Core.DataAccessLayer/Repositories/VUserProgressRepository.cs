using System.Linq;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserProgressRepository : IReadOnlyRepository<VUserProgress>
    {
        private readonly DimsCoreContext _context;

        public VUserProgressRepository(DimsCoreContext context)
        {
            _context = context;
        }

        public IQueryable<VUserProgress> GetAll()
        {
            return _context.VUserProgresses.AsNoTracking();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
