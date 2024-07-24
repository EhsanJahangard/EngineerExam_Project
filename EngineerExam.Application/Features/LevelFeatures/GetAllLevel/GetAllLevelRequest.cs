using MediatR;

namespace EngineerExam.Application.Features.LevelFeatures.GetAllLevel;

public sealed record GetAllLevelRequest : IRequest<List<GetAllLevelResponse>>;
