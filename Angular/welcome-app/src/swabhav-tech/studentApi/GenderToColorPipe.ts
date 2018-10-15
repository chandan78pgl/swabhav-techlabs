import { PipeTransform, Pipe } from "@angular/core";

@Pipe({name: 'genderToColorPipe'})
export class GenderToColorPipe implements PipeTransform{
    transform(value:string){
        if(value == "Male"){
            return "grey";
        }
        return "pink";
    }
}