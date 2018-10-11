export class Student{
    
    constructor(private _firstname:string,private _lastname:string){}

    public get Details():string{
        return `first Name is ${this._firstname}
        last Name is ${this._lastname}`;
    }
}

//let s1 = new Student("chandan","maharana");
//console.log(s1);
//console.log(s1.Details);