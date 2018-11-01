import { Component } from "@angular/core";
import { NavController, Tabs, Tab } from "ionic-angular";
import { IBasicDetails } from "../../../../Services/IBasicDetails";
import { RegistrationService } from "../../../../Services/registrationService";
import { TenantApiService } from "../../../../Services/tenantApiService";
import { IUserDetailsDTO } from "../../../../Services/IUserDetailsDTO";
import { IUserDTO } from "../../../../DTO/IUserDTO";

@Component({
    templateUrl:'./basicDetail.html'
})
export class BasicDetailsPage{
    
    customerName:string;
    street:string;
    city:string;
    state:string;
    zipCode:number;
    country:string;
    weburl:string;
    
    firstName:string;
    lastName:string;
    mobile:number;
    email:string;

    currency:string;

    constructor(public navCtrl:NavController,
                private _registrationService:RegistrationService,
                private _tenantApiService:TenantApiService){
        if (localStorage["loginId"]!=null) {
            this.getUserData(localStorage.getItem("loginId"));
        }
    }

    getUserData(id:string){
        
        this._tenantApiService.GetUser(id).then((response)=>{
            console.log(response.json());
            var data:IUserDTO = response.json();

            this.customerName = data.UserDetails.Name;
            this.street = data.UserDetails.AddressDetails[0].Street;
            this.city = data.UserDetails.AddressDetails[0].City;
            this.state = data.UserDetails.AddressDetails[0].State;
            this.country = data.UserDetails.AddressDetails[0].Country;
            this.zipCode = data.UserDetails.AddressDetails[0].ZipCode;
            this.weburl = data.UserDetails.WebUrl;

            this.firstName = data.UserDetails.ContactDetails[0].FirstName;
            this.lastName = data.UserDetails.ContactDetails[0].LastName;
            this.mobile = data.UserDetails.ContactDetails[0].Mobile;
            this.email = data.UserDetails.ContactDetails[0].Email;

            this.currency = data.UserDetails.Currency;
        });
    }
    addUserDetails(){
        var userDetails:IBasicDetails={
            CustomerName:this.customerName,
            Street:this.street,
            City:this.city,
            State:this.state,
            ZipCode:this.zipCode,
            Country:this.country,
            Weburl:this.weburl,
            FirstName:this.firstName,
            LastName:this.lastName,
            Mobile:this.mobile,
            Email:this.email,
            Currency:this.currency
        }
        this._registrationService.addBasicDetailsToUser(userDetails);
        this.selectTab(1);
    }

    selectTab(index:number){
        var t:Tabs = this.navCtrl.parent;
        var singleTab:Tab = t.getByIndex(index);
        singleTab.enabled=true;
        t.select(singleTab);
    }
}