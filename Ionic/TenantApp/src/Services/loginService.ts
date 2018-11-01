import { TenantApiService } from "./tenantApiService";
import { Injectable } from "@angular/core";

@Injectable()
export class LoginService{
    constructor(private _tenantApiService:TenantApiService){

    }

    authenticateUser(username:string,password:string){
        return this._tenantApiService.AuthenticateUser(username,password);
    }
}