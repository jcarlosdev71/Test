namespace Test.Api.Services;

public class GuidService
{
    public Guid Id { get; set; }
    public GuidService()
    {
        Id = Guid.NewGuid();
    }
}
