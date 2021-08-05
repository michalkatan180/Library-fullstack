import { Injectable } from '@angular/core';
import { Category } from '../classes/category'
import { Book } from '../classes/Book';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  categoryList: Category[] = [];
  api = 'https://localhost:44305/api/category';

  constructor(private http: HttpClient) {
    /*  this.categoryList.push(new Category("noar", "metach", "rgb(204, 4, 87)",1));
      this.categoryList.push(new Category("noar", "komix", "rgb(243, 119, 171)",2));
      this.categoryList.push(new Category("children", "sipurim", "rgb(4, 204, 121)",3));
      this.categoryList.push(new Category("mevugarim", "sipurim", "rgb(250, 253, 82)",4));*/
  }

  /*getAll(): Category[] {
    return this.categoryList;
  }*/

  getAll(): Observable<Category[]> {
    return this.http.get<Category[]>(this.api);
  }
  getCategory(id: number): Observable<Category> {
    return this.http.get<Category>(this.api + "/" + id);
  }
}
