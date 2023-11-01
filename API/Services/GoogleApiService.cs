using API.Helpers;
using API.Interfaces;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services;
public class GoogleApiService: IGoogleApiService
{
    private readonly BooksService _service;
    public GoogleApiService(IOptions<GoogleSettings> config)
    {
        _service = new BooksService(new BaseClientService.Initializer
        {
            ApiKey = config.Value.ApiKey
        });
    }

    public async Task<Volumes> FindBooks(string query)
    {
        var request = _service.Volumes.List(query);
        

        var response = await request.ExecuteAsync();
        return response;
    }
}
