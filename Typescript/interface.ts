interface ICustomer{
    fname:string,
    lname:string,
    salary:number
}

function printSalaryslip(customers:ICustomer[]):void{
    for(let c of customers){
        console.log(c);
    }
}

printSalaryslip([
    {fname:"chandan",lname:"maharana",salary:20000},
    {fname:"dharmesh",lname:"nayak",salary:10000}
]);