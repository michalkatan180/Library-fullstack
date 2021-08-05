import { Component, OnInit } from '@angular/core';
import { LendingService } from '../services/lending.service'
import { Lending } from '../classes/lending'

@Component({
  selector: 'app-lendings',
  templateUrl: './lendings.component.html',
  styleUrls: ['./lendings.component.css']
})
export class LendingsComponent implements OnInit {

  constructor(private lendingService: LendingService) { }

  ngOnInit(): void {
    //this.lendings = this.lendingService.getAll();
    this.lendingService.getAll().subscribe(x => this.lendings = x);
  }
  lendings: Lending[] = [];
  isLate(l: Lending): boolean {
    l.returnDate = new Date(l.returnDate);
    l.lendingDate = new Date(l.lendingDate);
    if (l.returnDate.getFullYear() != 1990) return false;//כבר החזיר
    var d = new Date();
    var diff = Math.abs(d.getTime() - l.lendingDate.getTime());
    var diffDays = Math.ceil(diff / (1000 * 3600 * 24));
    return diffDays > 30;
  }


  isReturn(l: Lending): boolean {
    //  לא ניתן להוסיף לטבלה השאלה ללא תאריך החזרה
    //לכן אם עדיין לא החזיר, השנה היא 1990
    l.returnDate = new Date(l.returnDate);
    if (l.returnDate.getFullYear() == 1990) return false;
    return true;
  }
}