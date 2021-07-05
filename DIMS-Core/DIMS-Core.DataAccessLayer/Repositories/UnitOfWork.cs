using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using TaskEntity = DIMS_Core.DataAccessLayer.Models.Task;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    /// <summary>
    ///     This class is unit of work pattern.
    ///     He is pretty popular in projects which have repository approach and using when you need to have access to many
    ///     repositories in one class under one context.
    ///     You can read about the pattern in Internet.
    /// </summary>
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DimsCoreContext _context;

        public UnitOfWork(DimsCoreContext context,
                          IRepository<UserProfile> userProfileRepository,
                          IRepository<Direction> directionRepository,
                          IReadOnlyRepository<VUserProfile> vUserProfileRepository,
                          IRepository<TaskEntity> taskRepository,
                          IRepository<TaskState> taskStateRepository,
                          IRepository<TaskTrack> taskTrackRepository,
                          IRepository<UserTask> userTaskRepository,
                          IReadOnlyRepository<VTask> vTaskRepository,
                          IReadOnlyRepository<VUserProgress> vUserProgressRepository,
                          IReadOnlyRepository<VUserTask> vUserTaskRepository,
                          IReadOnlyRepository<VUserTrack> vUserTrackRepository)
        {
            _context = context;

            UserProfileRepository = userProfileRepository;
            DirectionRepository = directionRepository;
            VUserProfileRepository = vUserProfileRepository;
            TaskRepository = taskRepository;
            TaskStateRepository = taskStateRepository;
            TaskTrackRepository = taskTrackRepository;
            UserTaskRepository = userTaskRepository;
            VTaskRepository = vTaskRepository;
            VUserProgressRepository = vUserProgressRepository;
            VUserTaskRepository = vUserTaskRepository;
            VUserTrackRepository = vUserTrackRepository;
        }

        public IRepository<UserProfile> UserProfileRepository { get; }

        public IRepository<Direction> DirectionRepository { get; }

        public IReadOnlyRepository<VUserProfile> VUserProfileRepository { get; }

        public IRepository<TaskEntity> TaskRepository { get; }

        public IRepository<TaskState> TaskStateRepository { get; }

        public IRepository<TaskTrack> TaskTrackRepository { get; }

        public IRepository<UserTask> UserTaskRepository { get; }

        public IReadOnlyRepository<VTask> VTaskRepository { get; }

        public IReadOnlyRepository<VUserProgress> VUserProgressRepository { get; }

        public IReadOnlyRepository<VUserTask> VUserTaskRepository { get; }

        public IReadOnlyRepository<VUserTrack> VUserTrackRepository { get; }

        /// <summary>
        ///     This method is not important here because each repository already has same method.
        ///     But remember you can use repositories separately from unit of work. So 'Save' method exists in UnitOfWork and
        ///     Repository.
        /// </summary>
        /// <returns></returns>
        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}