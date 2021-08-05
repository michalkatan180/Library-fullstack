import { Component, OnInit, Input } from '@angular/core';
import { Category } from '../classes/category';

@Component({
  selector: 'app-show-category',
  templateUrl: './show-category.component.html',
  styleUrls: ['./show-category.component.css']
})
export class ShowCategoryComponent implements OnInit {

  constructor() { }

  @Input() inputCategory: Category;
  ngOnInit(): void {
  }

}
