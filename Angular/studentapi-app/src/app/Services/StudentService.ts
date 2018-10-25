import { Http } from "@angular/http";
import { Injectable } from "@angular/core";

@Injectable()
export class StudentService{

    constructor(private http:Http){

    }
    
    getAll(){
        return this.http.get("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students").toPromise();
    }

    get(studentId:number){
        return this.http.get("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/"+studentId).toPromise();
    }

    add(newStudent:any){
        return this.http.post("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students",newStudent).toPromise();
    }

    delete(studentId:number){
        return this.http.delete("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/" + studentId).toPromise();
    }

    update(studentId:number,student:any){
        return this.http.put("http://gsmktg.azurewebsites.net:80/api/v1/techlabs/test/students/" + studentId,student).toPromise();
    } 
}