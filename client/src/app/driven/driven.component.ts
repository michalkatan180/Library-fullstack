import { Component, OnInit } from '@angular/core';
import { Lending } from '../classes/lending';
import { Book } from '../classes/book'
import { Borrower } from '../classes/borrower'
import { LendingService } from '../services/lending.service'
import { BookService } from '../services/book.service'
import { BorrowerService } from '../services/borrower.service'
import { FormBuilder, Validators, FormControl } from '@angular/forms'
import { Router } from '@angular/router'
@Component({
  selector: 'app-driven',
  templateUrl: './driven.component.html',
  styleUrls: ['./driven.component.css']
})
//טופס הוספת השאלה
export class DrivenComponent implements OnInit {
  allBorrowers: Borrower[] = [];
  allBooks: Book[] = [];
  allBLendings: Lending[] = [];
  myDriven = this.fb.group({
    borrowerId: new FormControl("", Validators.required),//קוד(לא ת"ז) של השואל
    bookId: new FormControl("", Validators.required)
  });
  constructor(private fb: FormBuilder, private BorrowerService: BorrowerService,
    private lendingService: LendingService, private bookService: BookService, private router: Router) {
  }
  ngOnInit(): void {
    /*this.allBorrowers = this.BorrowerService.getAll();
    this.allBooks = this.bookService.getAll();*/
    this.BorrowerService.getAll().subscribe(borrowers => this.allBorrowers = borrowers);
    this.bookService.getAll().subscribe(books => this.allBooks = books);
  }
  save(): void {
    //id: number,borrowerId:number, borrowerFirstName: string,
    // borrowerLastName: string, bookId: number, bookTitle: string, 
    //lendingDate: Date, returnDate: Date

    let borr=this.BorrowerService.getName(this.myDriven.value.borrowerId);
let ti=this.bookService.getTitle(this.myDriven.value.bookId);
    this.lendingService.add(
      new Lending(0, Number(this.myDriven.value.borrowerId) , borr[0], borr[1],Number(this.myDriven.value.bookId) ,ti, new Date(), new Date(1990,1,1))
      ).subscribe(() => this.router.navigate(["toLendings"]));
  }
}
