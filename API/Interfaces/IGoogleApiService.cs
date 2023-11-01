using Google.Apis.Books.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interfaces;
public interface IGoogleApiService
{
    Task<Volumes> FindBooks(string query);
}
