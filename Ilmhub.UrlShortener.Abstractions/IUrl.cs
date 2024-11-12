namespace Ilmhub.UrlShortner.Abstractions;

public interface IUrl
{
    int Id {get; set;}
    string Name {get; set;}
    string Original {get;set;}
    string Code{get;set;}
    DateTimeOffset CreatedAt {get;set;}
    int AccessCount {get;set;}
}
