import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { TenantMenuPage } from '../pages/menuPages/tenantMenu';

import { PartnersPage } from '../pages/MasterModule/partners/partners';
import { ModulesPage } from '../pages/MasterModule/modules/modules';
import { ServicesPage } from '../pages/MasterModule/services/services';

import { TenantProfilePage } from '../pages/UserModule/profile/tenantProfile';
import { WelcomeKitPage } from '../pages/UserModule/welcome_kit/welcome_kit';
import { AnnouncementPage } from '../pages/announcement/announcement';

import { BasicDetailsPage } from '../pages/UserModule/registration/basicDetail/basicDetail';
import { LoginDetailsPage } from '../pages/UserModule/registration/LoginDetail/loginDetail';
import { SubscriptionDetailsPage } from '../pages/UserModule/registration/subscriptionDetail/subscriptionDetail';
import { RegistrationTabsPage } from '../pages/tabPages/registration/registrationTabs';
import { LoginPage } from '../pages/userLogin/login';
import { RegistrationService } from '../Services/registrationService';
import { HttpModule } from '@angular/http'; 
import { FormsModule } from '@angular/forms';
import { TenantApiService } from '../Services/tenantApiService';
import { LoginService } from '../Services/loginService';

@NgModule({
  declarations: [
    MyApp,
    HomePage,
    TenantMenuPage,
    PartnersPage,
    ModulesPage,
    ServicesPage,
    TenantProfilePage,
    WelcomeKitPage,
    AnnouncementPage,
    BasicDetailsPage,
    LoginDetailsPage,
    SubscriptionDetailsPage,
    RegistrationTabsPage,
    LoginPage
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    TenantMenuPage,
    PartnersPage,
    ModulesPage,
    ServicesPage,
    TenantProfilePage,
    WelcomeKitPage,
    AnnouncementPage,
    BasicDetailsPage,
    LoginDetailsPage,
    SubscriptionDetailsPage,
    RegistrationTabsPage,
    LoginPage
  ],
  providers: [
    StatusBar,
    SplashScreen,,
    RegistrationService,
    TenantApiService,
    LoginService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}