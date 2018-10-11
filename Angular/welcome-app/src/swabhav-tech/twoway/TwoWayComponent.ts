import { Component } from "@angular/core";
import { MathService } from "../MathService";

@Component({
    templateUrl:"./TwoWayComponent.html",
    selector:"st-twoway"
})
export class TwoWayComponent{
    firstName:string;
    lastName:string;
    inputNumber:number;
    result:string;

    constructor(private _mathService:MathService){
        this.firstName="chandan";
        //this.result="The Result is";
    }

    firstNameChanged(event){
        this.firstName=event;
    }

    checkPrimeNumber(value:number){
        if(this._mathService.isPrime(value)){
            this.result=value+" is Prime";
            return;
        }
        this.result=value+" is Not Prime";
        return;
    }

    checkAsyncPrimeNumber(value:number){
        console.log("functioncalled");
        this._mathService.isPrimeAsync(value).then((success)=>{

            this.updateResult(value+" is prime");
            console.log(this.result);

        }).catch((fail)=>{

            this.updateResult(value+" is Not Prime");
            console.log(this.result);

        });
    }

    updateResult(text:string){
        this.result=text;
    }
}