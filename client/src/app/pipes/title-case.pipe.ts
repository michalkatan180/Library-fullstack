import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'titleCase'
})
export class TitleCasePipe implements PipeTransform {
  transform(value: string, ...args: unknown[]): string {
    if (value.includes(' ')) {
      var i, str = "";
      for (i = 0; i < value.length && value[i] != ' '; i++) {
        str += value[i];
      }
      str += " " + value[i + 1] + ".";
      return str;
    }
    return value;
  }

}
