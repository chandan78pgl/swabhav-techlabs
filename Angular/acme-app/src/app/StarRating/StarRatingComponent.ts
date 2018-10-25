import { Component, Input } from "@angular/core";

@Component({
    templateUrl:"./StarRatingComponent.html",
    selector:"st-stars"
})
export class StarRatingComponent{

    @Input()
    rating:number;

    constructor(){
        
    }
}