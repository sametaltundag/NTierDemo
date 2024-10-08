﻿using AutoMapper;
using Smt.TodoAppNTier.Dtos.WorkDtos;
using Smt.TodoAppNTier.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smt.TodoAppNTier.Business.Mappings.AutoMapper
{
    public class WorkProfile : Profile
    {
        public WorkProfile()
        {
            CreateMap<Work,WorkListDto>().ReverseMap();
            CreateMap<Work,WorkCreateDto>().ReverseMap();
            CreateMap<Work,WorkUpdateDto>().ReverseMap();
            CreateMap<WorkListDto, WorkUpdateDto>().ReverseMap();
        }
    }
}
