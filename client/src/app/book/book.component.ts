import { Component, OnInit } from '@angular/core';
import { Book } from '../classes/Book';
import { BookService } from '../services/book.service';
import { ActivatedRoute } from '@angular/router';
import { Category } from '../classes/category';
import { CategoryService } from '../services/category.service';
@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  constructor(private bookService: BookService, private activatedRoute: ActivatedRoute, private categoryService: CategoryService) { }
  b: Book;
  c: Category;
  //categoryList: Category[] = [];

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      this.bookService.getBook(params.id).subscribe(bo => {
        this.b = bo;
        if (!this.b) {
          console.log("איך מציגים שגיאה 404"); //שגיאה 404
        };
        this.categoryService.getCategory(this.b.ageCategory).subscribe(cat => { this.c = cat });
      });

    })
  }

  IsBig(): boolean { return this.b.pageCount > 400; }
  IsSmall(): boolean { return this.b.pageCount < 50 && this.b.pageCount != 1; }

}