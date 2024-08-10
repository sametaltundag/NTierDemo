using Smt.TodoAppNTier.Dtos.Interfaces;
using Smt.TodoAppNTier.Dtos.WorkDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smt.TodoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<List<WorkListDto>> GetAll();
        Task Create(WorkCreateDto dto);

        Task<IDto> GetById<IDto>(int id);

        Task Remove(int id);

        Task Update(WorkUpdateDto dto);
    }
}
