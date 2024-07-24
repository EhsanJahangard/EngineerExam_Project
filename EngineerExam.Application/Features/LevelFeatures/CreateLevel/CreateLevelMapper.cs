using AutoMapper;
using EngineerExam.Domain.Models;


namespace EngineerExam.Application.Features.LevelFeatures.CreateLevel;
public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateLevelRequest, Level>();
        CreateMap<Level, CreateLevelResponse>();
    }
}