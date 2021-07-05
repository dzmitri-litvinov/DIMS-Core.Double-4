using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class TaskRepository : Repository<Task>
    {
        public TaskRepository(DimsCoreContext context) : base(context)
        {
        }
    }
}