using AutoMapper;
using EngineerExam.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Application.Features.LevelFeatures.GetAllLevel;
public sealed class GetAllLevelMapper : Profile
{
    public GetAllLevelMapper()
    {
        CreateMap<Level, GetAllLevelResponse>();
    }
}