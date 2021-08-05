import { Component, OnInit } from '@angular/core';
import { Book } from '../classes/Book';
import { BookService } from '../services/book.service'
import { CategoryService } from '../services/category.service';
import { Category } from '../classes/category';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  constructor(private bookService: BookService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    // this.books = this.bookService.getAll();
    //this.activatedRoute.params.subscribe(p=>this.books=this.bookService.getAll(p.id));

    this.activatedRoute.params.subscribe(p => this.bookService.getByCategoey(p.id).subscribe(x => this.books = x));
  }

  books: Book[] = [];
  searchTxt: string;

  check(b: Book): boolean {
    return (b.id == 0 || b.author == "" || b.title == "");
  }
 
}