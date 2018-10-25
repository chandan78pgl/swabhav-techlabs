import { Component } from "@angular/core";
import { NavController } from "ionic-angular";
import { ExpenseTrackerService } from "../../services/ExpenseTrackerService";
import { IExpense } from "../../services/IExpense";

@Component({
    templateUrl:'./ExpenseAdd.html'
})
export class ExpenseAdd{
    expenseId:number;
    expenseCategory:string;
    expenseDescription:string;
    expenseDate:string;

    constructor(public navCtrl:NavController,private _expenseTrackerService:ExpenseTrackerService){

    }

    close(){
        this.navCtrl.pop();
    }

    addExpense(){
        let expense:IExpense;
        expense = {
            id:this.expenseId,
            category:this.expenseCategory,
            date:this.expenseDate,
            description:this.expenseDescription
        }
        
console.log(expense);
        this._expenseTrackerService.add(expense);

        this.navCtrl.pop();
    }
}