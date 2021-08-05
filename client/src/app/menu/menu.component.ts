import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  constructor() {   
    console.log(    "ctor"  );//1
  }

  ngOnInit(): void {
    console.log("oninit");//2
  }

}
