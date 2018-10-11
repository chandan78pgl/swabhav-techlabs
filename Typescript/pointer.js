class Point {
    constructor() {
        this._x = 0;
        this._y = 0;
    }
    set X(x) {
        if (x >= 0) {
            this._x = x;
        }
    }
    get X() {
        return this._x;
    }
    set Y(y) {
        if (y > 0) {
            this._y = y;
        }
    }
    get Y() {
        return this._y;
    }
}
var p1 = new Point();
console.log(p1);
p1.X = 10;
p1.Y = 20;
console.log(p1.X, p1.Y);
console.log(p1);
