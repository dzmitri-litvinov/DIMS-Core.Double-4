using System;
using AliasThreading = System.Threading.Tasks;
using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserProfile> UserProfileRepository { get; }

        IRepository<Direction> DirectionRepository { get; }

        IReadOnlyRepository<VUserProfile> VUserProfileRepository { get; }

        AliasThreading.Task Save();
    }
}