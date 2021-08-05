import { Pipe, PipeTransform } from '@angular/core';
import { Book } from '../classes/Book';
import { BookService } from '../services/book.service'

@Pipe({
  name: 'textSearch'
})
export class TextSearchPipe implements PipeTransform {

  constructor(private bookService: BookService) {
    //    this.books = this.bookService.getAll();
    this.bookService.getAll().subscribe(b => this.books = b);
  }

  books: Book[] = [];

  searchTxt: string;

  transform(toSearch: string, ...args: any[]) {
    this.bookService.getAll().subscribe(b => this.books = b);
    var str = "";
    for (var i = 0; i < this.books.length; i++) {
      if (this.books[i].title.toUpperCase().includes(toSearch.toUpperCase())) {
        str +=this.books[i].title + ".    ";
      }
    }
    return str;
  }


}
