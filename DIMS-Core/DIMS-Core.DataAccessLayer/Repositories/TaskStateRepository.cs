using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    class TaskStateRepository : Repository<TaskState>
    {
        public TaskStateRepository(DimsCoreContext context) : base(context)
        {

        }
    }
}
