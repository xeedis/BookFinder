using API.DTOs;
using API.Helpers;
using API.Interfaces;
using Google.Apis.Books.v1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers;
public class BooksController: BaseApiController
{
    private readonly IGoogleApiService _googleApiService;
    private readonly BookMapper _bookMapper;

    public BooksController(IGoogleApiService googleApiService, BookMapper bookMapper)
    {
        _googleApiService = googleApiService;
        _bookMapper = bookMapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Volume>>> GetBooks([FromQuery] string parameters)
    {
        var books = await _googleApiService.FindBooks(parameters);

        var result = new List<BookDto>();
        foreach (var book in books.Items)
        {
            result.Add(_bookMapper.MapBooks(book));
        }
        return Ok(result);
    }
}
