var x = 40;
//x="hello"
var tempname = "Swabhav";
var isValid = true;
console.log("Welcome Typescript");
console.log(x);
console.log(tempname);
console.log(isValid);
function cubeEvenNumber(value) {
    if (value % 2 == 0) {
        return value * value * value;
    }
    else {
        throw new Error("Not an even number");
    }
}
try {
    var answer = cubeEvenNumber(10);
    console.log(answer);
}
catch (e) {
    console.log(e);
}
var display = "Displaying values \n                value: " + x + "\n                fname: " + tempname + "\n";
console.log(display);
