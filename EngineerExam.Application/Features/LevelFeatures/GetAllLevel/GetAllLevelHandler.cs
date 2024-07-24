using AutoMapper;
using EngineerExam.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineerExam.Application.Features.LevelFeatures.GetAllLevel;
public sealed class GetAllLevelHandler : IRequestHandler<GetAllLevelRequest, List<GetAllLevelResponse>>
{
    private readonly ILevelRepository _levelRepository;
    private readonly IMapper _mapper;

    public GetAllLevelHandler(ILevelRepository levelRepository, IMapper mapper)
    {
        _levelRepository = levelRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllLevelResponse>> Handle(GetAllLevelRequest request, CancellationToken cancellationToken)
    {
        var levels = await _levelRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllLevelResponse>>(levels);
    }
}