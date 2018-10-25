import { Component } from "@angular/core";

@Component({
    templateUrl:"./ParentChildComponent.html",
    selector:"st-parentChild"
})
export class ParentChildComponent{

    stateOfButton:string;
    showRating:string;
    constructor(){
        this.stateOfButton="None";
    }

    handler(data){
        console.log(data);
        this.stateOfButton=data;
    }

    ratingHandler(data){
        this.showRating=data;
    }
}