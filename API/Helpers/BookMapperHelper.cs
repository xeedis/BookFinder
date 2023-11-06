using API.DTOs;
using Google.Apis.Books.v1.Data;

namespace API.Helpers;

public class BookMapper
{
    public BookDto MapBooks(Volume book)
    {
        return new BookDto
        {
            Title = book.VolumeInfo.Title,
            Authors =  book.VolumeInfo.Authors,
            Description = book.VolumeInfo.Description,
            Thumbnail = book.VolumeInfo.ImageLinks.Thumbnail
        };
    }
}
