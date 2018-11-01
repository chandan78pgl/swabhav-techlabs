import { Http } from "@angular/http";
import { IUserDetailsDTO } from "./IUserDetailsDTO";
import { Injectable } from "@angular/core";
import { ILoginDetailsDTO } from "../DTO/ILoginDetailsDTO";
import { ISubscriptionDetailsDTO } from "../DTO/ISubscriptionDetailsDTO";

@Injectable()
export class TenantApiService{
    constructor(private _http:Http){

    }

   AddUser(user:IUserDetailsDTO,login:ILoginDetailsDTO,subscription:ISubscriptionDetailsDTO){
        return this._http.post("http://192.168.2.6/tenant-api/api/tenant/User/Register",{
            UserDetails:user,
            LoginDetails:login,
            SubscriptionDetails:subscription
    }).toPromise();
   }

   GetUser(id:string){
       return this._http.get("http://192.168.2.6/tenant-api/api/tenant/User/Id?Id="+id).toPromise();
   }

   AuthenticateUser(username:string, password:string){
       console.log(username,password);
        return this._http.post("http://192.168.2.6/tenant-api/api/tenant/Login/AuthenticateUser",{
            Username:username,
            Password:password
        }).toPromise();
   }


}