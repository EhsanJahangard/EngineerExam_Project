using AutoMapper;
using EngineerExam.Application.Repositories;
using EngineerExam.Domain.Models;
using MediatR;

namespace EngineerExam.Application.Features.LevelFeatures.CreateLevel;

public sealed class CreateLevelHandler : IRequestHandler<CreateLevelRequest, CreateLevelResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILevelRepository _LevelRepository;
    private readonly IMapper _mapper;

    public CreateLevelHandler(IUnitOfWork unitOfWork, ILevelRepository LevelRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _LevelRepository = LevelRepository;
        _mapper = mapper;
    }

    public async Task<CreateLevelResponse> Handle(CreateLevelRequest request, CancellationToken cancellationToken)
    {
        var level = _mapper.Map<Level>(request);
        _LevelRepository.Create(level);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateLevelResponse>(level);
    }
}