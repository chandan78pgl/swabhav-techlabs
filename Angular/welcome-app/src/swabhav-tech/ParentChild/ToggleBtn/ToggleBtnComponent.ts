import { OnInit, Component, Input, EventEmitter, Output } from "@angular/core";

@Component({
    templateUrl:"./ToggleBtnComponent.html",
    selector:"st-toggle-btn"
})
export class ToggleBtnComponent implements OnInit {

    @Input()
    textContent:string;
    @Input()
    onStateColor:string;
    @Input()
    offStateColor:string;
    @Output()
    stateChanged:EventEmitter<string>;

    stateColor:string;
    state:boolean;

    constructor(){
        console.log("Inside Constructor");
        this.state=false;
        this.stateChanged=new EventEmitter<string>();
    }
    ngOnInit() {
        console.log("Inside OnInit Method");
        console.log(this.textContent);
        console.log("On State - "+this.onStateColor);
        console.log("Off State - "+this.offStateColor);
        
        this.stateColor=this.offStateColor;
    }

    toggleBtn(){ 
        if(!this.state){
            this.stateChanged.emit(`State is changed to off to on - `+this.onStateColor);
            this.state=true;
            return this.stateColor=this.onStateColor;
        }
        this.stateChanged.emit(`State is changed to on to off - `+this.offStateColor);
        this.state=false;
        return this.stateColor=this.offStateColor;
    }
}