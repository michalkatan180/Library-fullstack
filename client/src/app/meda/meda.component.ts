import { Component, OnInit } from '@angular/core';
import { BorrowerService } from '../services/borrower.service';

@Component({
  selector: 'app-meda',
  templateUrl: './meda.component.html',
  styleUrls: ['./meda.component.css']
})
export class MedaComponent implements OnInit {

  constructor(private borrowerService: BorrowerService) { }

  bo_cnt: number;
  ngOnInit(): void {
    this.borrowerService.getAll().subscribe(data => this.bo_cnt = data.length);
  }

}