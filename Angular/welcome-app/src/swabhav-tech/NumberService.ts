import { Http } from "@angular/http";
import { Injectable } from "@angular/core";

@Injectable()
export class NumberService{

    constructor(private http:Http){
    }
    
    getDataFromNumberApi(id:number){
        return this.http.get("http://numbersapi.com/"+id).toPromise();
    }
}