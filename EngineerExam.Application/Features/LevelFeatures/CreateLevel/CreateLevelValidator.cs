using FluentValidation;

namespace EngineerExam.Application.Features.LevelFeatures.CreateLevel;

public class CreateLevelValidator : AbstractValidator<CreateLevelRequest>
{
    public CreateLevelValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MinimumLength(3).MaximumLength(50);
    }
}