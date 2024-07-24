using EngineerExam.Application.Features.LevelFeatures.CreateLevel;
using EngineerExam.Application.Features.LevelFeatures.GetAllLevel;
using EngineerExam.WebApi.Filters;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EngineerExam.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ExampleFilter))]
    public class LevelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LevelController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<GetAllLevelResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllLevelRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateLevelResponse>> Create(CreateLevelRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
   
}
