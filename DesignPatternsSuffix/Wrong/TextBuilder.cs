namespace DesignPatternsSuffix.Wrong;

public class TextBuilder
{
    public string Title { get; }
    public string Description { get; }
    public string? Subtitle { get; }
    public string? AdditionalInfo { get; }

    public TextBuilder(string title, string description, string? subtitle = null, string? additionalInfo = null)
    {
        Title = title;
        Description = description;
        Subtitle = subtitle;
        AdditionalInfo = additionalInfo;
    }

    public string GenerateText()
    {
        var subtitle = $"{(Subtitle != null ? $"[{Subtitle}]" : string.Empty)}";
        return $"{Title}{subtitle}_{Description}_{AdditionalInfo}";
    }
}