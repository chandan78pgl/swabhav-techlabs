import { PipeTransform, Pipe } from "@angular/core";

@Pipe({name: 'summaryPipe'})
export class SummaryPipe implements PipeTransform{
    transform(value: string, length: number){
        let newSummary = value.substring(0,length);
        return newSummary+"...";
    }
}