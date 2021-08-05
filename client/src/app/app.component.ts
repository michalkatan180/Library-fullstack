import { Component } from '@angular/core';
import { MyFirst2Component } from './my-first2/my-first2.component';
import {myFirstComponent} from './my-first/my-first.component'
import {TestComponent} from './test/test.component';
import {BookComponent}from './book/book.component'
import {CategoryComponent}from './category/category.component'


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'project';
}
