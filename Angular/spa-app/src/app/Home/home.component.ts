import { Component } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    templateUrl:"./home.component.html"
})
export class HomeComponent{

    constructor(private route:Router){
        
    }

    gotoService(){
        this.route.navigate(['/Service/101']);
    }
}