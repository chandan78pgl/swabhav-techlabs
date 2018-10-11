import { Component } from "@angular/core";
import { IGameButton } from "./IGameButton";

@Component({
    templateUrl:"./bluebox.component.html",
    selector:"st-bluebox"
})
export class BlueBox {
    buttons:IGameButton[];
    answer:number;
    guesses:number;
    isCalled:boolean;

    constructor(){
        this.answer=Math.round(Math.random()*50);
        this.guesses=5;
        this.isCalled=false;
    }

    createButtons(){
        if(!this.isCalled){
            this.buttons= new Array(50);
            for(let i=0;i<this.buttons.length;i++){
                this.buttons[i]={
                    id:i+1,
                    isCalled:false,
                    btnStyle:{background:'grey',
                                color:'white',
                                height:'50px',
                                width:'50px',
                                margin: '2px'
                            }
                };
            }
        }
        this.isCalled=true;
    }

    game(id:number):void{
        if(this.checkGuess()){
            this.guesses--;
            let btn = this.getButton(id);

            if(id<this.answer){
                btn.btnStyle.background='red';
            }
            else if(id>this.answer){
                btn.btnStyle.background='green';
            }else if(id==this.answer){
                this.guesses=0;
                btn.btnStyle.background='blue';
                setTimeout(() => {
                    alert("Congrats You Found the Correct Ball");
                }, 500); 
            }
        }

        if(!this.checkGuess() && id!=this.answer){
            let correctButton = this.getButton(this.answer);
            correctButton.btnStyle.background='blue';
            setTimeout(() => {
                alert("Sorry You are out of your guesses Correct Ball is "+this.answer);
            }, 500);
        }
    }

    checkGuess():boolean{
        if(this.guesses>0){
            return true;
        }
        return false;
    }

    getButton(id:number):any{
        for(let btn of this.buttons){
            if(btn.id==id){
                btn.isCalled=true
                return btn;
            }
        }
        return null;
    }
}