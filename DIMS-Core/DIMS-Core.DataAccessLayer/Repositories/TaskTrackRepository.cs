using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    class TaskTrackRepository : Repository<TaskTrack>
    {
        public TaskTrackRepository(DimsCoreContext context) : base(context)
        {

        }
    }
}
