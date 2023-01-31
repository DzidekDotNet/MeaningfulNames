// See https://aka.ms/new-console-template for more information

Console.WriteLine(new DesignPatternsSuffix.Wrong.TextBuilder("title", "description").GenerateText());
Console.WriteLine(new DesignPatternsSuffix.Wrong.TextBuilder("title", "description", "subtitle").GenerateText());
Console.WriteLine(new DesignPatternsSuffix.Wrong.TextBuilder("title", "description", "subtitle", "additionalData").GenerateText());
Console.WriteLine(new DesignPatternsSuffix.Good.TextBuilder("title", "description").GenerateText());
Console.WriteLine(new DesignPatternsSuffix.Good.TextBuilder("title", "description").AddSubtitle("subtitle").GenerateText());
Console.WriteLine(new DesignPatternsSuffix.Good.TextBuilder("title", "description").AddSubtitle("subtitle").AddAdditionalInfo("additionalData").GenerateText());