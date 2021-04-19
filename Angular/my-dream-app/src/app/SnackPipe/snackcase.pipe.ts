import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
    name: "snackCase"
})
export class SnackCasePipe implements PipeTransform {
    transform(value: string): string {
        var words: string[] = value.split(" ");
        var newValue: string;

        if (words.length <= 0) {
            newValue = words.join("_");
        }
        else {
            words.slice(0, value.length);
            newValue = words.join("_");
        }
        return newValue;
    }

}