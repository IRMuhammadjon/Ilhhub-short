namespace Ilmhub.UrlShortner.Abstractions;

public interface IUrlShortner
{
    string ShortenUrl(string longUrl);
    string GetOriginalUrl(string ShortCode);
    IEnumerable<IUrl> GetPaginatedUrls(int pageNumber = 1, int pageSize = 10);
}
