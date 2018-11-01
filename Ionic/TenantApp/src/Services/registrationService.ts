import { IUser } from "./IUser";
import { IBasicDetails } from "./IBasicDetails";
import { ILoginDetails } from "./ILoginDetails";
import { ISubscriptionDetails } from "./ISubscriptionDetails";
import { IUserDetailsDTO } from "./IUserDetailsDTO";
import { TenantApiService } from "./tenantApiService";
import { Injectable } from "@angular/core";
import { ILoginDetailsDTO } from "../DTO/ILoginDetailsDTO";
import { ISubscriptionDetailsDTO } from "../DTO/ISubscriptionDetailsDTO";

@Injectable()
export class RegistrationService {
    User:IUser;

    constructor(private _tenantApiService:TenantApiService) {
        this.User={
            BasicDetails:null,
            LoginDetails:null,
            SubscriptionDetails:null
        }
    }

    addBasicDetailsToUser(basicDetails:IBasicDetails){
        this.User.BasicDetails=basicDetails;
        console.log(this.User.BasicDetails);
        
    }

    addLoginDetailsToUser(loginDetails:ILoginDetails){
        this.User.LoginDetails=loginDetails;
        console.log(this.User.LoginDetails);
    }

    addSubscriptionDetailsToUser(subscriptionDetails:ISubscriptionDetails){
        this.User.SubscriptionDetails=subscriptionDetails;
        console.log(this.User.SubscriptionDetails);
        return this.registerUser();
    }

    registerUser(){

        var userDTO:IUserDetailsDTO={
            Name:this.User.BasicDetails.CustomerName,
            Role:"customer",
            Currency:this.User.BasicDetails.Currency,
            ShortName:this.User.LoginDetails.ShortName,
            WebUrl:this.User.BasicDetails.Weburl,
            AddressDetails:[{
                Street:this.User.BasicDetails.Street,
                City:this.User.BasicDetails.City,
                Country:this.User.BasicDetails.Country,
                State:this.User.BasicDetails.State,
                ZipCode:this.User.BasicDetails.ZipCode
            }],

            ContactDetails:[{
                FirstName:this.User.BasicDetails.FirstName,
                LastName:this.User.BasicDetails.LastName,
                Mobile:this.User.BasicDetails.Mobile,
                Email:this.User.BasicDetails.Email
            }]
        }

        var loginDTO:ILoginDetailsDTO={
            Username:this.User.LoginDetails.Username,
            Password:this.User.LoginDetails.Password,
            Captcha:this.User.LoginDetails.Captcha
        }

        var subscriptionDTO:ISubscriptionDetailsDTO={
            Type:this.User.SubscriptionDetails.SubscriptionType,
            NoOfNamedUsers:this.User.SubscriptionDetails.NoOfUsers,
            Modules:this.User.SubscriptionDetails.Modules,
            Services:this.User.SubscriptionDetails.Services
        }
        return this._tenantApiService.AddUser(userDTO,loginDTO,subscriptionDTO);
    }
}