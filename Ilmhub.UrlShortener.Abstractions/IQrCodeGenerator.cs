namespace Ilmhub.UrlShortner.Abstractions;

public interface IQrCodeGenerator
{
    string GenerateQrCodeSvgString(
        string content,
        string foreground = "black",
        string background = "white");
    Task GenerateQrCodeAndSaveAsync(
        string path,
        string content,
        EQrCodeFileType fileType = EQrCodeFileType.Svg,
        string foreground = "black",
        string background = "white");
    
}
