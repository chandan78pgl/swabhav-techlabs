import { LoginService } from "../services/LoginService";
import { IUser } from "../services/IUser";
import { Router } from "@angular/router";
import { Component } from "@angular/core";

@Component({
    templateUrl:'./login.component.html'
})
export class LoginComponent{
    username:string;
    password:string;
    user:IUser;
    constructor(private _loginService:LoginService,private route:Router){
    }

    authUser(){
        this.user={
            username:this.username,
            password:this.password
        }
        if(this._loginService.authenticateUser(this.user)){
            return this.route.navigate(['/Contact']);
        }
    }
}