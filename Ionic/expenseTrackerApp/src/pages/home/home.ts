import { Component } from '@angular/core';
import { NavController, AlertController } from 'ionic-angular';
import { ExpenseTrackerService } from '../../services/ExpenseTrackerService';
import { IExpense } from '../../services/IExpense';
import { ExpenseDetails } from '../Details/ExpenseDetails';
import { ExpenseAdd } from '../AddExpense/ExpenseAdd';
import { AuthService } from '../../services/AuthService';
import { Login } from '../Login/login';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  constructor(public navCtrl: NavController,
              private _expenseTrackerService:ExpenseTrackerService,
              private _authService:AuthService,
              private _alertCtrl:AlertController){
  }

  getAllExpenses():IExpense[]{
    return this._expenseTrackerService.get();
  }  

  goToDetailsPage(expense:IExpense){
    console.log(expense);
    this.navCtrl.push(ExpenseDetails,{
      expenseObj:expense
    });
  }

  gotoAddPage(){
    this.navCtrl.push(ExpenseAdd);
  }

  logout(){
    let alert = this._alertCtrl.create({
      title:'Logout',
      message:'Are you sure you want to logout?',

      buttons:[
        {
          text:'Cancel',
          role:'cancel',
          handler:()=>{
            console.log("logout canceled");
          }
        },{
          text:'Logout',
          handler:()=>{
            this._authService.logout();
            this.navCtrl.setRoot(Login);
          }
        }
      ]
    });
    alert.present();
  }
}
