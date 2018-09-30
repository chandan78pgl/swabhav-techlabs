employee=function(firstname,lastname){
    this.firstname=firstname;
    this.lastname=lastname;
    this.getFullName=function(){
        return this.firstname+" "+this.lastname;
    };
    return this;
}