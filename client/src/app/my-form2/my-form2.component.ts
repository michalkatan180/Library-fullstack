import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BorrowerService } from '../services/borrower.service'
import { Router } from '@angular/router'
import { CategoryService } from '../services/category.service'
import { Category } from '../classes/category'
@Component({
  selector: 'app-my-form2',
  templateUrl: './my-form2.component.html',
  styleUrls: ['./my-form2.component.css']
})
export class MyForm2Component implements OnInit {//הוספת שואל

  emailRegex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
  myFormGroup: FormGroup = new FormGroup({
    id: new FormControl(""),
    tz: new FormControl("", [Validators.required, Validators.minLength(9), Validators.maxLength(9), Validators.pattern('[0-9]*')]),
    ageCategory: new FormControl(),
    firstName: new FormControl("Michal"),
    lastName: new FormControl(),
    phoneNumber: new FormControl("", Validators.pattern('[0-9]*')),
    email: new FormControl("", Validators.pattern(this.emailRegex))
  });
  allCategory: Category[] = [];
  constructor(private borrowerService: BorrowerService, private router: Router, private categoryService: CategoryService) {
    //    this.getAllCategory = this.categoryService.getAll();
  }
  ngOnInit(): void {
    this.categoryService.getAll().subscribe(c => this.allCategory = c);
  }

  @Output() added = new EventEmitter<String>();
  @Input() displayForm: string;//ניתן לאתחל זאת בסלקטור


  save(): void {
    // if (this.myFormGroup.value.id != null && this.myFormGroup.value.tz != null)
    this.myFormGroup.value.id = 0;
    this.myFormGroup.value.ageCategory = Number(this.myFormGroup.value.ageCategory);
    this.borrowerService.addBorrower(this.myFormGroup.value).subscribe(() => {
      this.router.navigate(["toBorrowers"]);//אבל למה לא מרענן את התצוגה עד שאלחץ שוב על הלינק של שואלים
      this.added.emit();
      //this.myFormGroup.reset();
    });
  }
}
