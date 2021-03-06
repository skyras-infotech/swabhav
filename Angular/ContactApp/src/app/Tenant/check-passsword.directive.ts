import { AbstractControl, NG_VALIDATORS, Validators } from "@angular/forms";
import { Directive, Input } from "@angular/core";

@Directive({
    selector:'[passwordValidator]',
    providers:[{
        provide:NG_VALIDATORS,
        useExisting:CheckPasswordEquality,
        multi:true,
    }]
})
export class CheckPasswordEquality implements Validators
{
    @Input() passwordValidator: string
    validate(control: AbstractControl):{[key:string]:any} | null {
        const controlToCompare = control.parent.get(this.passwordValidator);
        if(controlToCompare && controlToCompare.value !== control.value){
            return {'notEqual':true}
        }
        return null;
    }
}