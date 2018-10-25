import { Component, OnInit } from "@angular/core";
import { StudentService } from "../Services/StudentService";
import { Router } from "@angular/router";

@Component({
    templateUrl: "./home.component.html"
})
export class HomeComponent implements OnInit {
    Students: any[];

    constructor(private _studentService: StudentService, private _router:Router) {
        this.Students = [];
    }

    ngOnInit() {
        this.getAllStudents();
    }

    getAllStudents() {
        return this._studentService.getAll().then((response) => {
            this.Students = response.json();
        });
    }

    deleteStudent(studentId:number){
        return this._studentService.delete(studentId).then((response)=>{
            this.getAllStudents();
        });
    }
}