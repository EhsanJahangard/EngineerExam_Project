using AutoMapper;
using EngineerExam.Application.Repositories;
using MediatR;

namespace EngineerExam.Application.Features.LevelFeatures.GetAllLevel;


public sealed record GetAllLevelResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
}