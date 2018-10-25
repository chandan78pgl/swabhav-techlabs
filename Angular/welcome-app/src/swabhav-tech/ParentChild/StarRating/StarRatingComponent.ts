import { OnInit, Component, Input, EventEmitter, Output } from "@angular/core";

@Component({
    templateUrl:"./StarRatingComponent.html",
    selector:"st-stars"
})
export class StarRatingComponent implements OnInit{

    @Input()
    rating:number;


    @Output()
    displayRating:EventEmitter<string>;

    constructor(){
        this.displayRating=new EventEmitter<string>();
    }
    ngOnInit(){
        
    }

    showRating(){
        return this.displayRating.emit(`You have got ${this.rating} star ratings`);
    }

    hideRating(){
        return this.displayRating.emit("Hover Again");
    }
}