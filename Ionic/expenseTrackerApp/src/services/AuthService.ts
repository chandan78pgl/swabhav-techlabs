export class AuthService{
    username:string;
    password:string;

    constructor(){
        localStorage["username"]="chandan";
        localStorage["password"]="root";

        this.username=localStorage.getItem("username");
        this.password=localStorage.getItem("password");
    }

    authenticateUser(loginUsername:string,loginPassword:string):boolean{
        
        if(localStorage.getItem("username")!=null && localStorage.getItem("password")!=null){
            if(loginUsername==this.username && loginPassword==this.password){
                localStorage["loginStatus"]=true;
                return true;
            }
        }
        return false;
    }

    logout(){
        console.log("logoutSuccessful");
        localStorage.removeItem("loginStatus");
    }
}