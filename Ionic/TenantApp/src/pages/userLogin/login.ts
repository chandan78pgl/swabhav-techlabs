import { Component } from "@angular/core";
import { NavController } from "ionic-angular";
import { TenantMenuPage } from "../menuPages/tenantMenu";
import { LoginService } from "../../Services/loginService";

@Component({
    templateUrl:'./login.html'
})
export class LoginPage{
    username:string;
    password:string;
    
    constructor(public navCtrl:NavController,private _loginService:LoginService){

    }

    gotoTenantHome(){
        this._loginService.authenticateUser(this.username,this.password).then((response)=>{
            if (response.json()!=null) {
                console.log(response.json());
                localStorage["loginId"]=response.json();
                this.navCtrl.setRoot(TenantMenuPage);        
            }
        }).catch((reject)=>{
            console.log("Login Failed",reject);
        });
    }
}