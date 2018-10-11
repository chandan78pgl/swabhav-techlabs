var x:number=40;
//x="hello"
var tempname:string = "Swabhav";

var isValid:boolean = true;
console.log("Welcome Typescript");
console.log(x);
console.log(tempname);
console.log(isValid);

function cubeEvenNumber(value:number):number{
        if(value%2==0){ 
            return value*value*value;
        }
        throw new Error("Not an even number");
}

try{
    var answer = cubeEvenNumber(10);
    console.log(answer);
}
catch(e){
    console.log(e);
}

let display = `Displaying values 
                value: ${x}
                fname: ${tempname}
`

console.log(display);