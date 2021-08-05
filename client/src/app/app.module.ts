import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { myFirstComponent } from './my-first/my-first.component';
import { MyFirst2Component } from './my-first2/my-first2.component';
import { TestComponent } from './test/test.component';
import { MaakavComponent } from './maakav/maakav.component';
import { CategoryComponent } from './category/category.component';
import { BookComponent } from './book/book.component';
import { BookListComponent } from './book-list/book-list.component';
import { BorrowerComponent } from './borrower/borrower.component';
import { TitleCasePipe } from './pipes/title-case.pipe';
import { PipesUsedComponent } from './pipes-used/pipes-used.component';
import { TextSearchPipe } from './pipes/text-search.pipe';
import { MenuComponent } from './menu/menu.component';
import { RouterModule, Routes } from '@angular/router';
import { LendingsComponent } from './lendings/lendings.component';
import { MyErorComponent } from './my-eror/my-eror.component';
import { PratimComponent } from './pratim/pratim.component';
import { TakanonComponent } from './takanon/takanon.component';
import { MedaComponent } from './meda/meda.component';
import { AboutComponent } from './about/about.component';
import { MyForm2Component } from './my-form2/my-form2.component';
import { DrivenComponent } from './driven/driven.component';
import { NioolComponent } from './niool/niool.component';
import { ChooseFormComponent } from './choose-form/choose-form.component';
import { AddBookFormComponent } from './add-book-form/add-book-form.component';
import { ShowCategoryComponent } from './show-category/show-category.component';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = []
@NgModule({

  declarations: [
    AppComponent,
    myFirstComponent,
    MyFirst2Component,
    TestComponent,
    MaakavComponent,
    CategoryComponent,
    BookComponent,
    BookListComponent,
    BorrowerComponent,
    TitleCasePipe,
    PipesUsedComponent,
    TextSearchPipe,
    MenuComponent,
    LendingsComponent,
    MyErorComponent,
    MedaComponent,
    PratimComponent,
    TakanonComponent,
    AboutComponent,
    MyForm2Component,
    DrivenComponent,
    NioolComponent,
    ChooseFormComponent,
    AddBookFormComponent,
    ShowCategoryComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    // RouterModule.forRoot(routes)
    ReactiveFormsModule,
    HttpClientModule
  ],
 // exports: [],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
