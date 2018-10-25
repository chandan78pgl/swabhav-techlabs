import { IExpense } from "./IExpense";


export class ExpenseTrackerService{

    Expenses:IExpense[];

    constructor(){
        if (JSON.parse(localStorage.getItem("Expenses"))!=null) {
            this.Expenses = JSON.parse(localStorage.getItem("Expenses"));
            return;
        }
        this.Expenses=[];
    }

    get(){
        return this.Expenses ;
    }


    update(newExpense:IExpense){
        for (let index = 0; index < this.Expenses.length; index++) {
            if(this.Expenses[index].id==newExpense.id){
                this.Expenses[index]=newExpense;
            }
        }
        this.updateStorage();
    }

    add(newExpense:IExpense){
        
        this.Expenses.push(newExpense);
        this.updateStorage();
    }

    delete(expense:IExpense){
        for (let index = 0; index < this.Expenses.length; index++) {
            if(this.Expenses[index].id==expense.id){
                this.Expenses.splice(index,1);
            }
        }
        this.updateStorage();
    }

    updateStorage(){
        localStorage["Expenses"]=JSON.stringify(this.Expenses);
    }
}