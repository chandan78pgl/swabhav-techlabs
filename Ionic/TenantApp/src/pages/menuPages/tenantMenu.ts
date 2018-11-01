import { Component, ViewChild } from "@angular/core";
import { HomePage } from "../home/home";
import { Nav } from "ionic-angular";

import { ModulesPage } from "../MasterModule/modules/modules";
import { ServicesPage } from "../MasterModule/services/services";
import { PartnersPage } from "../MasterModule/partners/partners";
import { TenantProfilePage } from "../UserModule/profile/tenantProfile";
import { WelcomeKitPage } from "../UserModule/welcome_kit/welcome_kit";
import { AnnouncementPage } from "../announcement/announcement";
import { RegistrationTabsPage } from "../tabPages/registration/registrationTabs";
import { BasicDetailsPage } from "../UserModule/registration/basicDetail/basicDetail";

@Component({
    templateUrl:'./tenantMenu.html'
})
export class TenantMenuPage{
    @ViewChild(Nav) nav: Nav;
    
    rootPage: any=HomePage;
    
    pages:Array<{title: string, component: any,isHide:boolean,componentList :Array<{title: string, component: any}>}>;

    constructor(){
        this.pages = [
            { 
                title: 'Masters', 
                component:null,
                isHide:true,
                componentList: [{
                    title: 'Modules',
                    component: ModulesPage,
                },{
                    title: 'Services',
                    component: ServicesPage
                },{
                    title: 'Partners',
                    component: PartnersPage
                }
            ] 
            },
            {
                title:'Customer',
                component:null,
                isHide:true,
                componentList:[
                    {
                        title: 'Register',
                        component: RegistrationTabsPage
                    },
                    {
                        title: 'Tenant Profile',
                        component: RegistrationTabsPage
                    },
                    {
                        title: 'Welcome Kit',
                        component: WelcomeKitPage
                    },
                    {
                        title: 'Announcements',
                        component: AnnouncementPage
                    }
                ]
            }
          ];
    }

    openPage(page) {
        // Reset the content nav to have just this page
        // we wouldn't want the back button to show in this scenario
        this.nav.setRoot(page.component);
      }

    toggleSubMenu(page){
        if (page.isHide) {
            return page.isHide=false;
        }
        return page.isHide=true;
    }
}