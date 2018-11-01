import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { ExpenseTrackerService } from '../services/ExpenseTrackerService';
import { ExpenseDetails } from '../pages/Details/ExpenseDetails';
import { ExpenseAdd } from '../pages/AddExpense/ExpenseAdd';
import { Login } from '../pages/Login/login';
import { AuthService } from '../services/AuthService';
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    MyApp,
    HomePage,
    ExpenseDetails,
    ExpenseAdd,
    Login
  ],
  imports: [
    BrowserModule,
    FormsModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    ExpenseDetails,
    ExpenseAdd,
    Login
  ],
  providers: [
    StatusBar,
    SplashScreen,
    ExpenseTrackerService,
    AuthService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
