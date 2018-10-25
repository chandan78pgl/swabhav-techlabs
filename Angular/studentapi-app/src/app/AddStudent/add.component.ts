import { StudentService } from "../Services/StudentService";
import { Router } from "@angular/router";
import { Component } from "@angular/core";

@Component({
    templateUrl:'./add.component.html'
})
export class AddStudentComponent{
    
    student_rollNo:number;
    student_name:string;
    student_age:number;
    student_email:string;
    student_date:string;

    constructor(private _studentService:StudentService,private _router:Router){

    }

    addStudent(){
        let student = {
            rollNo:this.student_rollNo,
            name:this.student_name,
            age:this.student_age,
            email:this.student_email,
            date:this.student_date
        }

        this._studentService.add(student).then((response)=>{
            console.log(response.text().toString());
            this._router.navigate(['/']);
        });
    }
}