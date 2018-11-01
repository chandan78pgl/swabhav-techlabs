import { Component } from "@angular/core";
import { TenantApiService } from "../../../Services/tenantApiService";
import { IUserDetailsDTO } from "../../../Services/IUserDetailsDTO";

@Component({
    templateUrl:'./tenantProfile.html'
})
export class TenantProfilePage{
    
    Id:string;
    Data:IUserDetailsDTO;

    constructor(private _tenantApiService:TenantApiService){
        if (localStorage["loginId"]!=null) {
            this.Id = localStorage.getItem("loginId");
            this.getUserData();
        }
    }

    getUserData(){
        
        this._tenantApiService.GetUser(this.Id).then((response)=>{
            console.log(response.json());
            this.Data = response.json();
            console.log(this.Data);
        });
    }


}