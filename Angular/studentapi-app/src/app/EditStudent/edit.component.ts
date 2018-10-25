import { Component, OnInit } from "@angular/core";
import { StudentService } from "../Services/StudentService";
import { Router, ActivatedRoute } from "@angular/router";

@Component({
    templateUrl:'./edit.component.html'
})
export class EditStudentComponent implements OnInit{
    edit_rollNo:number;
    edit_name:string;
    edit_age:number;
    edit_email:string;
    edit_date:string;

    constructor(private _studentService:StudentService,private _route:ActivatedRoute,private _router:Router){
        
    }
    ngOnInit(){
        this._route.params.subscribe((param)=>this.edit_rollNo=param.id);

        this._studentService.get(this.edit_rollNo).then((response)=>{
             let student = response.json();

             this.edit_name=student.name;
             this.edit_age=student.age;
             this.edit_email=student.email;
             this.edit_date=student.date;

        });
    }
    updateStudent(){
        let student = {
            rollNo:this.edit_rollNo,
            name:this.edit_name,
            age:this.edit_age,
            email:this.edit_email,
            date:this.edit_date
        }

        this._studentService.update(student.rollNo,student).then((response)=>{
            console.log(response.text());
            this._router.navigate(['/']);
        });
    }
}