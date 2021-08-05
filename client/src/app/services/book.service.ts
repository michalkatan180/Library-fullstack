import { Injectable } from '@angular/core';
import { Book } from '../classes/Book';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { toUnicode } from 'punycode';

@Injectable({ providedIn: 'root' })

export class BookService {
  //books: Book[] = [];
  tmp: Book[] = [];
  api = 'https://localhost:44305/api/book';
  constructor(private http: HttpClient) {
    /* this.books.push(new Book(100, "Shatul", "Yona Sapir", "'MERAGEL-LEHASKARA' books are the best books, for everyone...", 1, 600));
     this.books.push(new Book(101, "Starim", "Dvora Rozen", "bla bla bla", 1, 500));
     this.books.push(new Book(102, "Hachuliya", "Nachman Seltzer", "bla bla bla", 1, 500));
     this.books.push(new Book(0, "Timrot Ashan", "P.Charif", "bla bla bla", 4, 500));
     this.books.push(new Book(103, "Hatzlalim", "Nachman Seltzer", "bla bla bla", 2, 500));
     this.books.push(new Book(104, "Bilty Hafich", "M.Arbel", "bla bla bla", 3, 500));
     this.books.push(new Book(105, "Hamoach", "A.Unger", "bla bla bla", 1, 500));
     this.books.push(new Book(106, "Mevukas", "Yona Sapir", "bla bla bla", 2, 500));
     this.books.push(new Book(107, "Hametzula", "Yona Sapir", "bla bla bla", 3, 500));
     this.books.push(new Book(108, "Hatzavaa", "Chayim Grinboim", "bla bla bla", 3, 500));*/
  }
  /* getAll(id?: number): Book[] {
    if (id != null) return this.filter(id);
    return this.books;
  }
  getBook(id: number): Book {
    for (const x of this.books) {
      if (x.id == id) { return x };
    }
    return null; // ? איך לעשות ששגיאה 404 תופיע כאשר אין ספר עם הקוד המבוקש
  }
  filter(id?: number): Book[] {
    if (id == null) return this.books;
    this.tmp = [];
    for (var i = 0; i < this.books.length; i++) {
      if (this.books[i].ageCategory == id)
        this.tmp.push(this.books[i]);
    }
    return this.tmp;
  }
  add(book: Book): void {
    this.books.push(book);
  }*/

  getAll(id?: number): Observable<any> {
    if (id) return this.getBook(id);
    let b = this.http.get<Book[]>(this.api);
    return b;
  }

  getBook(id: number): Observable<Book> {
    return this.http.get<Book>(this.api + '/' + id);
  }

  getByCategoey(id: number): Observable<Book[]> {
    if (id) return this.http.get<Book[]>(this.api + "/byAge/" + id);
    return this.getAll();
  }

  addBook(book: Book): Observable<Book> {
    return this.http.post<Book>(this.api, book);
  }
  getTitle(id: number): string {
    let ti: string;
    this.getBook(id).subscribe(x => ti = x.title);
    return ti;
  }
}