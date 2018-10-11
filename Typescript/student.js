"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Student = /** @class */ (function () {
    function Student(_firstname, _lastname) {
        this._firstname = _firstname;
        this._lastname = _lastname;
    }
    Object.defineProperty(Student.prototype, "Details", {
        get: function () {
            return "first Name is " + this._firstname + "\n        last Name is " + this._lastname;
        },
        enumerable: true,
        configurable: true
    });
    return Student;
}());
exports.Student = Student;
//let s1 = new Student("chandan","maharana");
//console.log(s1);
//console.log(s1.Details);
