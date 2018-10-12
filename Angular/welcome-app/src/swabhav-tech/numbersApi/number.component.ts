import { Component } from "@angular/core";
import { NumberService } from "../NumberService";

@Component({
    templateUrl:"./number.component.html",
    selector:"st-numberApi"
})
export class NumberComponent{
    facts:string[];
    id:number;
    constructor(private _numberService:NumberService){
        this.facts=[];
    }
    getFacts(num:number){
        if(num!=null){
            this._numberService.getDataFromNumberApi(num).then((response)=>{
                    this.facts.push(response.text().toString());
                    
                    console.log(response.text().toString());
                });
        }
    }
}