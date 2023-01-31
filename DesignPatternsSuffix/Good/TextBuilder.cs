namespace DesignPatternsSuffix.Good;

public class TextBuilder
{
    public string Title { get; }
    public string Description { get; }
    public string? Subtitle { get; set; }
    public string? AdditionalInfo { get; set; }

    public TextBuilder(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public TextBuilder AddSubtitle(string subtitle)
    {
        Subtitle = subtitle;
        return this;
    }
    public TextBuilder AddAdditionalInfo(string additionalInfo)
    {
        AdditionalInfo = additionalInfo;
        return this;
    }
    
    public string GenerateText()
    {
        var subtitle = $"{(Subtitle != null ? $"[{Subtitle}]" : string.Empty)}";
        return $"{Title}{subtitle}_{Description}_{AdditionalInfo}";
    }
}