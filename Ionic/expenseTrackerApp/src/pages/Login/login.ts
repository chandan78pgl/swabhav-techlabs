import { Component } from "@angular/core";
import { NavController } from "ionic-angular";
import { AuthService } from "../../services/AuthService";
import { HomePage } from "../home/home";

@Component({
    templateUrl:'./login.html',
    selector:'page-login'
})
export class Login{
    loginUsername:string;
    loginPassword:string;

    constructor(public navCtrl:NavController,private _authService:AuthService){
        
    }

    checkUserLogin(){
        console.log(this.loginUsername,this.loginPassword);
        if(this._authService.authenticateUser(this.loginUsername,this.loginPassword)){
            this.navCtrl.setRoot(HomePage);   
        }
    }
}