namespace API.DTOs;

public class BookDto
{
    public string Title { get; set; }
    public IList<string> Authors { get; set; }
    public string Description { get; set; }
    public string? Thumbnail { get; set; }
}
