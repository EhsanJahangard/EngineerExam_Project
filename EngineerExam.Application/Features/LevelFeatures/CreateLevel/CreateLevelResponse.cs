namespace EngineerExam.Application.Features.LevelFeatures.CreateLevel;
public sealed record CreateLevelResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
}