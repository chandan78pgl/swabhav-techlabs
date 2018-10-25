import { IUser } from "./IUser";

export class LoginService{
    Users:IUser[];
    private user:IUser; 
    constructor(){
        this.Users=[];
        this.Users.push({
            username:'chandan',
            password:'root'
        });
        this.Users.push({
            username:'dharmesh',
            password:'pass'
        });              
    }

    private setUser(loginUser:IUser){
        this.user=loginUser;
    }

    getCurrentUser(){
        if(this.user!=null)
        {
            return this.user;
        }
        return null;
    }
    private getUser(loginUser:IUser):IUser{
        for (const user of this.Users) {
            if(user.username==loginUser.username){
                return user;
            }
        }
        return null;
    }

    authenticateUser(loginUser:IUser):boolean{
        let user = this.getUser(loginUser);
        if (user != null) {
            if (user.username == loginUser.username && user.password==loginUser.password) {
                this.setUser(user);
                return true;
            }    
        }
        return false;
    }
}