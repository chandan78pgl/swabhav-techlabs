import { Component } from "@angular/core";

@Component({
    templateUrl:'./percentageCalculator.html',
    selector:'page-percentageCalculator'
})
export class PercentageCalculator{
  firstPercentInput:number;
  firstNumberInput:number;
  firstAnswerDisplay:number;

  secondInput:number;
  secondNumberInput:number;
  secondAnswerDisplay:string;

  thirdFromInput:number;
  thirdToInput:number;
  thirdAnswerDisplay:string;

  constructor(){
    this.firstAnswerDisplay=0;
    this.secondAnswerDisplay="0%";
    this.thirdAnswerDisplay="0%";
  }
  
  calculateAnswer(choice){
    if (choice=='first' && this.firstPercentInput!=null && this.firstNumberInput!=null) {
        this.firstAnswerDisplay = (this.firstPercentInput*this.firstNumberInput)/100;
    }

    if (choice=='second' && this.secondInput!=null && this.secondNumberInput!=null) {
      if (this.secondNumberInput == 0) {
        return this.secondAnswerDisplay="0%";
      }
      this.secondAnswerDisplay = (this.secondInput*100)/this.secondNumberInput+"%"
    }

    if (choice=='third' && this.thirdFromInput!=null && this.thirdToInput!=null) {
      this.thirdAnswerDisplay=((this.thirdToInput-this.thirdFromInput)/this.thirdFromInput)*100+"%"
    }
  }
}