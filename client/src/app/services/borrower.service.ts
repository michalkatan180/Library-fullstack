import { Injectable } from '@angular/core';
import { Borrower } from '../classes/borrower';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})

export class BorrowerService {

  borrowerList: Borrower[] = [];
  api = 'https://localhost:44305/api/borrower';

  constructor(private http: HttpClient) {
    /*  this.borrowerList.push(new Borrower(1001, "1212", 4, "Michal", "Katan", "053-315-7271", "abc@gmail.com"));
      this.borrowerList.push(new Borrower(1002, "1313", 2, "Avigayil", "Levi", "053-999-9999", "abc@gmail.com"));
      this.borrowerList.push(new Borrower(1003, "1414", 3, "Margalit", "Levi", "053-333-3333", ""));
      this.borrowerList.push(new Borrower(1004, "1515", 4, "Adel", "Levi", "053-888-8888", "abc@gmail.com"));
      this.borrowerList.push(new Borrower(1005, "1616", 1, "Halel", "Levi", "", ""));
      this.borrowerList.push(new Borrower(1006, "1717", 1, "Yosef Chayim", "Katan", "054-847-4907", ""));
      this.borrowerList.push(new Borrower(1007, "1818", 1, "Ovadya Yosef", "Katan", "054-847-4907", ""));
      this.borrowerList.push(new Borrower(1008, "1919", 1, "Sholomo Salman", "Katan", "053-315-7271", ""));
  
      this.borrowerList.push(new Borrower(9900, "88880", 4, "Ester", "Ben-Mucha", "050-634-7999", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9901, "88881", 4, "Hadas", "Barina", "058-322-1455", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9902, "88882", 4, "Stav", "Graidy", "055-882-8052", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9903, "88883", 4, "Galya", "Harpak", "054-666-7979", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9904, "88884", 4, "Or", "Yaakov", "050-958-2399", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9905, "88885", 4, "Michal", "Yefet", "052-711-4066", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9906, "88886", 4, "Tehila", "Samucha", "054-644-5780", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9907, "88887", 4, "Carmit", "Ankry", "03-648-5350", "myClass@gmail.com"));
      this.borrowerList.push(new Borrower(9908, "88888", 4, "Michaela", "Katzav Rodrig", "053-275-5485", "myClass@gmail.com"));*/
  }

  /*getAll(): Borrower[] {
     return this.borrowerList;
   }
   getCnt(): number {
     return this.borrowerList.length;
   }
 
   addBorrower(b:Borrower):void{
     this.borrowerList.push(b);
   }*/

  getAll(): Observable<Borrower[]> {
    return this.http.get<Borrower[]>(this.api);
  }
  getBorrower(id: number): Observable<Borrower> {
    return this.http.get<Borrower>(this.api + "/" + id);
  }

  addBorrower(b: Borrower): Observable<Borrower> {
    console.log(b);
    debugger;
    return this.http.post<any>(this.api, b);
  }

  getName(id: number): string[] {
    let tmp: Borrower;
    let arr: string[] = [];
    this.getBorrower(id).subscribe(x => tmp = x);
    if (tmp) {
      arr[0] = tmp.firstName;
      arr[1] = tmp.lastName;
    } return arr;
  }
}
