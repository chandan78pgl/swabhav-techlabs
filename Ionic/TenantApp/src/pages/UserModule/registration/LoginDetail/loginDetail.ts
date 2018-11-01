import { Component } from "@angular/core";
import { Tabs, NavController, Tab } from "ionic-angular";
import { RegistrationService } from "../../../../Services/registrationService";
import { ILoginDetails } from "../../../../Services/ILoginDetails";
import { TenantApiService } from "../../../../Services/tenantApiService";
import { IUserDTO } from "../../../../DTO/IUserDTO";

@Component({
    templateUrl:'./loginDetail.html'
})
export class LoginDetailsPage{
    username:string;
    password:string;
    cnfPassword:string;
    shortName:string;
    captcha:string;
    
    constructor(public navCtrl:NavController,
                private _registrationService:RegistrationService,
                private _tenantApiService:TenantApiService){
        if (localStorage["loginId"]!=null) {
            this.getUserData(localStorage.getItem("loginId"));
        }
    }

    getUserData(id:string){
        this._tenantApiService.GetUser(id).then((response)=>{
            var data:IUserDTO = response.json();

            this.username = data.LoginDetails.Username;
            this.password = data.LoginDetails.Password;
            this.cnfPassword = data.LoginDetails.Password;
            this.captcha = data.LoginDetails.Captcha;
            this.shortName = data.UserDetails.ShortName;
        });
    }

    addLoginDetails(){
        var loginDetails:ILoginDetails={
            Username:this.username,
            Password:this.password,
            ShortName:this.shortName,
            Captcha:this.captcha
        }

        this._registrationService.addLoginDetailsToUser(loginDetails);
        this.selectTab(2);
    }

    selectTab(index:number){
        var t:Tabs = this.navCtrl.parent;
        var subscriptionTab:Tab = t.getByIndex(index);
        subscriptionTab.enabled=true;
        t.select(subscriptionTab);
    }
}