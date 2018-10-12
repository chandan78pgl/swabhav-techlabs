import { IQuestion } from "./IQuestion";

export class QuestionBankService{
    questions:IQuestion[];
    count:number;

    constructor(){
        this.questions =[{
            qId: 1,
            qDescription: "Who is the national animal?",
            qOptions: ["lion", "tiger", "elephant", "monkey"],
            qAnswer: function () {
              return this.qOptions[1];
            }
          }, {
            qId: 2,
            qDescription: "What is square root of 81?",
            qOptions: ["2", "3", "9", "7"],
            qAnswer: function () {
              return this.qOptions[2];
            }
          }, {
            qId: 3,
            qDescription: "What is the sum of 24+36?",
            qOptions: ["20", "65", "80", "60"],
            qAnswer: function () {
              return this.qOptions[3];
            }
          }, {
            qId: 4,
            qDescription: "What is cube root of 64?",
            qOptions: ["4", "3", "9", "7"],
            qAnswer: function () {
              return this.qOptions[0];
            }
          }, {
            qId: 5,
            qDescription: "What is the product of 3*4?",
            qOptions: ["10", "13", "12", "34"],
            qAnswer: function () {
              return this.qOptions[2];
            }
          }
        ];   

        this.count=this.questions.length;
    }

    next(){
        if(this.checkNextQuestion()){
          console.log(this.count);
            this.count--;
            return this.questions[this.questions.length-this.count-1];
        }
        return null;
    }

    checkNextQuestion(){
      if(this.count==0){
        return false;
      }
      return true;
    }
}