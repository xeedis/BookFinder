import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from './Book';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  books: any;
  apiUrl="https://localhost:5001/api/";

  constructor(private http: HttpClient) {}


  getBooks(query:string)
  {
    return this.http.get<Book[]>(this.apiUrl +'books?parameters='+query);
  }
}
