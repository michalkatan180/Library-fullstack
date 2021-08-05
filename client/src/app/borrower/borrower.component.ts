import { Component, OnInit, Input, Output } from '@angular/core';
import { Borrower } from '../classes/borrower';
import { BorrowerService } from '../services/borrower.service';

@Component({
  selector: 'app-borrower',
  templateUrl: './borrower.component.html',
  styleUrls: ['./borrower.component.css']
})
export class BorrowerComponent implements OnInit {

  constructor(private borrowerService: BorrowerService) { }

  ngOnInit(): void {
    //    this.borrowerList = this.borrowerService.getAll();
    this.borrowerService.getAll().subscribe(x => this.borrowerList = x);
  }
  borrowerList: Borrower[] = [];

  // @Input() added: string;

  gg: string; //    אם מחרוזת ריקה / נאל - לא מסומן, אחרת - מסומן
  clear_gg(): void {
    this.gg = "";
  }
}
