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
    inputColor:string;

    constructor(private _mathService:MathService){
        this.firstName="chandan";
        this.result="Enter number for result";
        
        
    }

    firstNameChanged(event){
        this.firstName=event;
    }

    // checkPrimeNumber(value:number){
    //     if(this._mathService.isPrime(value)){
    //         this.result=value+" is Prime";
    //         return;
    //     }
    //     this.result=value+" is Not Prime";
    //     return;
    // }

    checkAsyncPrimeNumber(){
        console.log("functioncalled");
       
        this._mathService.isPrimeAsync(this.inputNumber).then((success)=>{

            this.result=this.inputNumber+" is prime";
            this.inputColor="lightgreen";
            console.log(this.result);
            
        }).catch((fail)=>{
            this.result=this.inputNumber+" is Not prime";
            console.log(this.result);
            this.inputColor="red";
            
        });
    }

}