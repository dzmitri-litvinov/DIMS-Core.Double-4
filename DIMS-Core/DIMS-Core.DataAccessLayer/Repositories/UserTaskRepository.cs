using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    class UserTaskRepository : Repository<UserTask>
    {
        public UserTaskRepository(DimsCoreContext context) : base(context)
        {

        }
    }
}
