import { Component, OnInit } from '@angular/core'; import { valueOf } from 'q';
@Component({ selector: 'app-test', templateUrl: './test.component.html', styleUrls: ['./test.component.css'] })
export class TestComponent implements OnInit {
  constructor() { }
  ngOnInit(): void { }
  ans1: string = "בלהה"; userAns1: string;
  ans2: string = "זלפה"; userAns2: string;
  userAns3: string;
  ans4: string = "רבקה"; userAns4: string;
  mark: number;
  testName: string;
  quArr: Array<string> = ["מי הייתה שפחתה של רחל?",
    "מי הייתה שפחתה של לאה?",
    "מי הייתה אמו של דן?",
    "מי הייתה חמותה של רחל?"];
  nameEmpty(): boolean { return this.testName == undefined || this.testName == ""; }

  /****************************** this.cnt=0;  צריך לשים את איפה שהוא*********************/
  cnt: number = 0;
  cntFunc(e): string {
    this.cnt = this.cnt % 4; //לבינתיים עד שאמצא איפה מאפסים את המונה בכל הרצה של התכנית, אחרת וא מגיע ל6,7,8 ועוד
    this.cnt++;
    return this.cnt.toString();
  }

  check(): void {
    this.mark = 0;
    if (this.userAns1 == this.ans1) this.mark += 2.5; if (this.userAns2 == this.ans2) this.mark += 2.5;
    if (this.userAns3 == this.ans1) this.mark += 2.5; if (this.userAns4 == this.ans4) this.mark += 2.5;
    this.mark *= 10;
    if (this.mark > 70) alert(this.testName + " got very good mark!");
    else alert(this.testName + " got less mark!");
  }

  color: string = "mediumturquoise";
  nameEmptyStyle(): string {
    if (this.nameEmpty()) {
      return this.color;
    }
  }

  koteretSt(): string {
    if (!this.nameEmpty()) {
      return "6";
    }
    return "4";
  }

  koteretSt2(): string {
    if (!this.nameEmpty()) {
      return "bold";
      // return "bolder";
    }
    return "";
  }


}


