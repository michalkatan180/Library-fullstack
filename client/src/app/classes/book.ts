// import { AotCompiler } from '@angular/compiler';

export class Book {
    // constructor(id?: number, title?: string,
    //      author?: string, summary?: string, ageCategory?: number, pageCount?: number) {
    constructor(id?: number, title?: string,
        author?: string, summary?: string, ageCategory?: number, pageCount?: number) {
        this.ageCategory = ageCategory;
        this.author = author;
        this.id = id;
        this.pageCount = pageCount;
        this.summary = summary;
        this.title = title;
    }
    id: number;
    title: string;
    author: string;
    summary: string;
    ageCategory: number;
    pageCount: number;
}
