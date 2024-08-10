using AutoMapper;
using Smt.TodoAppNTier.Business.Interfaces;
using Smt.TodoAppNTier.DataAccess.UnitOfWork;
using Smt.TodoAppNTier.Dtos.WorkDtos;
using Smt.TodoAppNTier.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smt.TodoAppNTier.Business.Services
{
    internal class WorkService : IWorkService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public WorkService(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task Create(WorkCreateDto dto)
        {
            _uow.GetRepository<Work>().Create(_mapper.Map<Work>(dto));

            await _uow.SaveChanges();
        }

        public async Task<List<WorkListDto>> GetAll()
        {
            //var list =await _uow.GetRepository<Work>().GetAll();
            //var workList = new List<WorkListDto>();
            //if (list != null && list.Count> 0)
            //{
            //    foreach (var work in list)
            //    {
            //        workList.Add(new()
            //        {
            //            Definition = work.Definition,
            //            Id = work.Id,
            //            IsCompleted = work.IsCompleted
            //        });
            //    }
            //}


            return _mapper.Map<List<WorkListDto>>(await _uow.GetRepository<Work>().GetAll());
        }

        public async Task<WorkListDto> GetById(int id)
        {
            return _mapper.Map<WorkListDto>(await _uow.GetRepository<Work>().GetByFilter(x => x.Id == id));
        }

        public async Task Remove(int id)
        {
            _uow.GetRepository<Work>().Remove(id);
            await _uow.SaveChanges();
        }

        public async Task Update(WorkUpdateDto dto)
        {
            _uow.GetRepository<Work>().Update(_mapper.Map<Work>(dto));
            await _uow.SaveChanges();
        }
    }
}
