using System.Linq;
using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserTrackRepository : IReadOnlyRepository<VUserTrack>
    {
        private readonly DimsCoreContext _context;

        public VUserTrackRepository(DimsCoreContext context)
        {
            _context = context;
        }

        public IQueryable<VUserTrack> GetAll()
        {
            return _context.VUserTracks.AsNoTracking();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}