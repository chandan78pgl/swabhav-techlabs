import { BasicDetailsPage } from "../../UserModule/registration/basicDetail/basicDetail";
import { LoginDetailsPage } from "../../UserModule/registration/LoginDetail/loginDetail";
import { SubscriptionDetailsPage } from "../../UserModule/registration/subscriptionDetail/subscriptionDetail";
import { Component } from "@angular/core";

@Component({
    templateUrl:'./registrationTabs.html'
})
export class RegistrationTabsPage{
    tab1Root = BasicDetailsPage;
    tab2Root = LoginDetailsPage;
    tab3Root = SubscriptionDetailsPage;

    constructor(){
    }
}