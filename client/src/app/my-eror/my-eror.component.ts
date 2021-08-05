import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-my-eror',
  templateUrl: './my-eror.component.html',
  styleUrls: ['./my-eror.component.css']
})
export class MyErorComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
    this.router.navigate(['List']);
    this.router.navigate(['search',{term:'a'}]);
  }

}
