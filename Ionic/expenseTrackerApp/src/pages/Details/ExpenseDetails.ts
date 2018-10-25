import { Component } from "@angular/core";
import { NavController, NavParams, AlertController } from "ionic-angular";
import { IExpense } from "../../services/IExpense";
import { ExpenseTrackerService } from "../../services/ExpenseTrackerService";

@Component({
    templateUrl:'./ExpenseDetails.html',
    selector:'page-expenseDetails'
})
export class ExpenseDetails{
    expense:IExpense;

    constructor(public navCtrl:NavController,
                public _navParams:NavParams,
                private _expenseTrackerService:ExpenseTrackerService,
                private _alertCtrl:AlertController){
        this.expense = Object.assign({}, _navParams.get('expenseObj'));
        console.log(this.expense.date);
    }

    delete(){
        let alert = this._alertCtrl.create({
            title:'Delete',
            message:'Are you sure you want to Delete?',
      
            buttons:[
              {
                text:'No',
                role:'no',
                handler:()=>{
                  console.log("Delete canceled");
                }
              },{
                text:'Yes',
                handler:()=>{
                    this._expenseTrackerService.delete(this.expense);
                    this.navCtrl.pop();
                }
              }
            ]
          });
          alert.present();
        
    }
    close(){
        this.navCtrl.pop();
    }

    update(){
        this._expenseTrackerService.update(this.expense);
        this.navCtrl.pop();
    }
}