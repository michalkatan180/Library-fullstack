import { Injectable } from '@angular/core';
import { Lending } from '../classes/lending'
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LendingService {
  lending: Lending[] = [];
  api = 'https://localhost:44305/api/lending';

  constructor(private http: HttpClient) {
    /*   //להכניס השאלות לרשימת ההשאלות
       this.lending.push(new Lending(770, 88881, "Hadas", "Barina", 100, "Shatul", new Date("02/01/2021"), null));
       this.lending.push(new Lending(771, 88882, "Stav", "Graidy", 106, "Mevukas", new Date("02/01/2021"), new Date("08/01/2021")));
       this.lending.push(new Lending(772, 88880, "Ester", "Ben-Mucha", 105, "Hamoach", new Date("01/12/2020"), null));
       this.lending.push(new Lending(773, 88883, "Galya", "Harpak", 102, "Hachuliya", new Date("03/01/2020"), new Date("08/01/2021")));
       this.lending.push(new Lending(774, 88884, "Or", "Yaakov", 101, "Starim", new Date("10/10/2020"), null));
       this.lending.push(new Lending(775, 88885, "Michal", "Yefet", 103, "Hatzlalim", new Date("01/01/2021"), null));
       this.lending.push(new Lending(776, 88886, "Tehila", "Samucha", 104, "Bilty Hafich", new Date("08/01/2021"), new Date("10/01/2021")));
       this.lending.push(new Lending(777, 88887, "Carmit", "Ankry", 107, "Hametzula", new Date("08/01/2020"), null));
       this.lending.push(new Lending(778, 88888, "Michaela", "Katzav Rodrig", 108, "Hatzavaa", new Date("01/01/2021"), new Date("10/01/2021")));
   */
  }

  /*getAll(): Lending[] {
    return this.lending;
  }
  add(le: Lending): void {
    this.lending.push(le);
  } */
  
  getAll(): Observable<Lending[]> {
    return this.http.get<Lending[]>(this.api);
  }
  getLending(id: number): Observable<Lending> {
    return this.http.get<Lending>(this.api + "/" + id);
  }
  add(le: Lending): Observable<Lending> {
    return this.http.post<Lending>(this.api + '/', le);
  }
}
