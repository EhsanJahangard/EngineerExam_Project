using MediatR;

namespace EngineerExam.Application.Features.LevelFeatures.CreateLevel;


public sealed record CreateLevelRequest(string Title) : IRequest<CreateLevelResponse>;