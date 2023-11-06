import { Component } from '@angular/core';
import { BooksService } from './books.service';
import { Book } from './Book';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  searchQuery: string = '';
  books: Book[] = [];
  constructor(private booksService: BooksService){}

  search() {
    this.booksService.getBooks(this.searchQuery).subscribe(books=>{
      this.books = books
      console.log(this.books);
    }
    )
  }
}
