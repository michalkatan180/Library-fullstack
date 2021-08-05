import { Component, OnInit } from '@angular/core';
import { Category } from '../classes/category';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})

export class CategoryComponent implements OnInit {

  categoryList: Category[] = [];
  constructor(private categoryService: CategoryService) {

  }
  ngOnInit() {
   // this.categoryList = this.categoryService.getAll();
    this.categoryService.getAll().subscribe(c=>this.categoryList=c);
  }
  colorOfLinkAll:string="salmon";
}
