import { Component } from "@angular/core";
import { ActivatedRoute } from "@angular/router";

@Component({
    templateUrl:'./service.component.html'
})
export class ServiceComponent{
    display:string;

    constructor(private route:ActivatedRoute){
        this.route.params.subscribe(params => this.display=params.id);
    }
}