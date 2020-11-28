﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DIMS_Core.BusinessLayer.Interfaces;
using DIMS_Core.BusinessLayer.Models;
using DIMS_Core.DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.BusinessLayer.Services
{
    public class VUserProfileService : IVUserProfileService
    {
        private bool _disposedValue;

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public VUserProfileService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VUserProfileModel>> GetAll()
        {
            var vUserProfileEntities = _unitOfWork.VUserProfileRepository.GetAll();

            var vUserProfiles = _mapper.ProjectTo<VUserProfileModel>(vUserProfileEntities);

            return await vUserProfiles.ToListAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}