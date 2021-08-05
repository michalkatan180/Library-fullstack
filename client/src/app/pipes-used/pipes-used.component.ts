import { Component, OnInit } from '@angular/core';
import { BorrowerService } from '../services/borrower.service';
import { Borrower } from '../classes/borrower';

@Component({
  selector: 'app-pipes-used',
  templateUrl: './pipes-used.component.html',
  styleUrls: ['./pipes-used.component.css']
})
export class PipesUsedComponent implements OnInit {
  constructor(private borrowerService: BorrowerService) { }

  ngOnInit(): void {
// this.borrowerList=this.borrowerService.getAll();
 this.borrowerService.getAll().subscribe(b=>this.borrowerList=b);
  }
  borrowerList: Borrower[] = [];
}
