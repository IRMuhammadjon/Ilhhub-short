namespace Ilmhub.UrlShortner.Abstractions;

public interface IshortCodeGenerator
{
    string Generate(int length = 6);
    string Generate(string seed, int length = 6);
}
