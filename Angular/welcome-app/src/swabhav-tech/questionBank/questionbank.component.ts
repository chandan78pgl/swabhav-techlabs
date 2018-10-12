import { QuestionBankService } from "../services/questionBankService";
import { Component, ViewChild, ElementRef } from "@angular/core";
import { IQuestion } from "../services/IQuestion";

@Component({
    templateUrl: "./questionbank.component.html",
    selector: "st-questionBank"
})
export class QuestionBankComponent {
    @ViewChild('myCanvas') myCanvas:ElementRef;
    question: IQuestion;
    selectedAnswer: string;
    correctAnswers: string[];
    answers: string[];
    result:string;
    testStatus:boolean;

    constructor(private _questionBankService: QuestionBankService) {
        this.nextQuestion();
        this.answers = [];
        this.correctAnswers=[];
        this.testStatus=false;
    }

    nextQuestion() {
        if (this.selectedAnswer!=undefined && !this.testStatus) {
            this.answers.push(this.selectedAnswer);
            this.checkAnswer();
            this.selectedAnswer="none";
            console.log(this.answers);
            console.log(this.correctAnswers);
        }

        if (this._questionBankService.checkNextQuestion()) {
            return this.question = this._questionBankService.next();
        }

        return this.testStatus=true;
    }

    checkAnswer(){
        if(this.selectedAnswer==this.question.qAnswer()){
            this.correctAnswers.push(this.selectedAnswer);
        }
    }

    calculateResult(){
        if(this.testStatus){
            let score:number;
            score=(this.correctAnswers.length/this.answers.length)*100;
            this.result=this.showResult(score);
            this.createCanvas(score);
        }
    }

    showResult(score:number){
        if(score>=50){
            return "Congratulations!! You Have Passed the Exam Your Score is: "+score+"%";
        }
        return "Sorry!! You Have Failed the Exam Your Score is: "+score+"%";
    }

    createCanvas(percent:number){
        let cfr:CanvasRenderingContext2D = this.myCanvas.nativeElement.getContext('2d');
        
        cfr.fillStyle="green";

        function drawPie(cfx:CanvasRenderingContext2D,x:number,y:number,radius:number,angle1:number,angle2:number){
            cfx.beginPath();
            cfx.moveTo(x,y);
            cfx.arc(x,y,radius,2*Math.PI*angle1/100,2*Math.PI*angle2/100);
            cfx.fill();
        }

        drawPie(cfr,300,300,200,0,percent);
        cfr.fillStyle="red";
        drawPie(cfr,300,300,200,percent,100);
    }


}