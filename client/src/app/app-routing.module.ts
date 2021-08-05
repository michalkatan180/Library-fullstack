import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BookComponent } from './book/book.component';
import { BookListComponent } from './book-list/book-list.component';
import { BorrowerComponent } from './borrower/borrower.component';
import { LendingsComponent } from './lendings/lendings.component';
import { MyErorComponent } from './my-eror/my-eror.component';
import { PratimComponent } from './pratim/pratim.component';
import { TakanonComponent } from './takanon/takanon.component';
 import { MedaComponent } from './meda/meda.component';
import { AboutComponent } from './about/about.component';
import { NioolComponent } from './niool/niool.component';
import {DrivenComponent}from './driven/driven.component'
import {MyForm2Component} from './my-form2/my-form2.component'
import { FormsModule } from '@angular/forms';
import { AddBookFormComponent } from './add-book-form/add-book-form.component';
const routes: Routes = [{
  path: '',
  component: BookListComponent,
  pathMatch: 'full'
},{
  path: 'toBooks',
  component: BookListComponent
},
{
  path: 'toOneBook/:id',
  component: BookComponent
},
{
  path: 'toBorrowers',
  component: BorrowerComponent
},
{
  path: 'toLendings',
  component: LendingsComponent
}, {
  path: 'toOdot',
  component: AboutComponent,
  children: [
    {
      path: 'toMeda',
      component: MedaComponent
    }, {
      path: 'toTakanon',
      component: TakanonComponent
    }, {
      path: 'toPratim',
      component: PratimComponent
    }, {
      path: '',
      component: MedaComponent
    },
    {
      path: '**',
      component: MyErorComponent
    }
  ]
},
{
  path: 'toCategoryBooks/:id',
  component: BookListComponent
},
{
  path: 'toNiool',
  component: NioolComponent,
  children: [
    {
      path: 'addBorrower',
      component: MyForm2Component
    }, {
      path: 'addBook',
      component: AddBookFormComponent
    },
     {
      path: 'addLending',
      component: DrivenComponent
    }, 
     {
      path: '',
      component: MyForm2Component
    },
    {
      path: '**',
      component: MyErorComponent
    }
  ]
},
{
  path: '**',
  component: MyErorComponent
}
]
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {  }