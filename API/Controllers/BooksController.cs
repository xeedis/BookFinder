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

    public BooksController(IGoogleApiService googleApiService)
    {
        _googleApiService = googleApiService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Volume>>> GetBooks([FromQuery] string parameters)
    {
        var books = await _googleApiService.FindBooks(parameters);

        return Ok(books);
    }
}
