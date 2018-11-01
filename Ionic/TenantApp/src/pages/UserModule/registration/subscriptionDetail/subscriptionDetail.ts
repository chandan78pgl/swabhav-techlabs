import { Component } from "@angular/core";
import { NavController, App } from "ionic-angular";
import { LoginPage } from "../../../userLogin/login";
import { ISubscriptionDetails } from "../../../../Services/ISubscriptionDetails";
import { RegistrationService } from "../../../../Services/registrationService";

@Component({
    templateUrl:'./subscriptionDetail.html'
})
export class SubscriptionDetailsPage{

    subscriptionType:string;
    noOfUsers:number;
    Modules:string[];
    Services:string[];

    constructor(public app:App, public navCtrl:NavController,private _registrationService:RegistrationService){
        
    }

    addSubscriptionDetails(){

        var subscriptionDetails:ISubscriptionDetails={
            SubscriptionType:this.subscriptionType,
            NoOfUsers:this.noOfUsers,
            Modules:this.Modules,
            Services:this.Services
        }

        this._registrationService.addSubscriptionDetailsToUser(subscriptionDetails).then((response)=>{
            this.app.getRootNav().setRoot(LoginPage);
        });
    }
}