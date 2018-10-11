class Point{

    private _x = 0;
    private _y = 0;

    public set X(x:number){
        if(x>=0){
            this._x=x;
        }
    }

    public get X(){
        return this._x;
    }

    public set Y(y:number){
        if(y>0){
            this._y=y;
        }
    }

    public get Y(){
        return this._y;
    }
}

var p1:Point = new Point();

console.log(p1);
p1.X=10;
p1.Y=20;
console.log(p1.X,p1.Y);
console.log(p1);

