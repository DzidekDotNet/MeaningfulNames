namespace MethodsWithLoopsInside;

public record SubSections(string Title, string Description, int Pages);

public record Chapter(string Title, string Description, SubSections[] SubSections);

public record Book(string Title, string Author, Chapter[] Chapters);

public class MethodsWithLoopsInside
{
  public int CountPagesOfBooks(Book[] books)
  {
    int pages = 0;
    foreach (var book in books)
    {
      foreach (var chapter in book.Chapters)
      {
        foreach (var subSection in chapter.SubSections)
        {
          pages += subSection.Pages;
        }
      }
    }
    return pages;
  }
}

public class MethodsWithLoopsInsideWithExtractedEachLoop
{
  public int CountPagesOfBooks(Book[] books)
  {
    var pages = 0;
    foreach (var book in books)
    {
      pages = CountBookPages(book);
    }
    return pages;
  }
  private static int CountBookPages(Book book)
  {
    var pages = 0;
    foreach (var chapter in book.Chapters)
    {
      pages += CountChapterPages(chapter);
    }
    return pages;
  }
  private static int CountChapterPages(Chapter chapter)
  {
    var pages = 0;
    foreach (var subSection in chapter.SubSections)
    {
      pages += subSection.Pages;
    }
    return pages;
  }
}
