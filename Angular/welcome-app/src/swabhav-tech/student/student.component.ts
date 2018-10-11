import { IStudent } from "./IStudent";
import { Component } from "@angular/core";

@Component ({
    templateUrl: './student.component.html',
    selector: 'st-student'
})
export class StudentComponent {
    Student: IStudent;
    Students: IStudent[];

    imageWidth = 300;
    imageHeight = 200;
    constructor() {
        this.Student = {
            name: 'Chandan',
            location: 'Surat',
            cgpa: 8.0,
            photo: 'assets/pictures/wall.jpg'
        };
    }

    calculateColor(cgpa: number): string {
        if (cgpa > 6) {
            return 'green';
        }
        return 'red';
    }

    loadStudents() {
        this.Students = [
            {
                name: 'dharmesh',
                location: 'Surat',
                cgpa: 4.98,
                photo: 'assets/pictures/wall.jpg'
            },
            {
                name: 'foo',
                location: 'Mumbai',
                cgpa: 8.15,
                photo: 'assets/pictures/wall.jpg'
            },
            {
                name: 'bar',
                location: 'Mumbai',
                cgpa: 7.68,
                photo: 'assets/pictures/wall.jpg'
            }
        ];     
    }
}
