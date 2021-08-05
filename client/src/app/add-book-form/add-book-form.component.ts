// import { Component, OnInit } from '@angular/core';
// import { Book } from '../classes/book'
// import { BookService } from '../services/book.service'
// import { Router } from '@angular/router'
// @Component({
//   selector: 'app-add-book-form',
//   templateUrl: './add-book-form.component.html',
//   styleUrls: ['./add-book-form.component.css']
// })
// export class AddBookFormComponent implements OnInit {
//   b: Book;//=new Book(0,"","","",0,0);
//   constructor(private bookService: BookService, private router: Router) { }

// ngOnInit(): void { this.b = new Book(0, "", "", "", 0, 0); }

//   save(): void {
//     alert(this.b.id);
//     this.bookService.add(this.b);
//     this.router.navigate(["toBooks"]);
//   }
// }
import { Component, OnInit } from '@angular/core';
import { BookService } from '../services/book.service';
import { Router } from '@angular/router';
import { Book } from '../classes/Book';
import { Observable } from 'rxjs';
// import { NgForm } from '@angular/forms';
// import { CategoryService } from '../services/category.service';
// import { Category } from '../classes/category';
import { Category } from '../classes/category';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-add-book-form',
  templateUrl: './add-book-form.component.html',
  styleUrls: ['./add-book-form.component.css']
})
export class AddBookFormComponent implements OnInit {

  b: Book;
  categoryList: Category[];
  constructor(private router: Router, private bookService: BookService, private categoryService: CategoryService) { }

  ngOnInit(): void {
    this.b = new Book();
    this.categoryService.getAll().subscribe(data => this.categoryList = data);
    //this.categoryList = this.categoryService.getAll();
  }

  save(): void {
    this.b.id = 0;
    this.b.ageCategory = parseInt(this.b.ageCategory.toString());
    this.b.pageCount=Number(this.b.pageCount);
    this.bookService.addBook(this.b).subscribe(() => { this.router.navigate(['toBooks']); });
  }

}
