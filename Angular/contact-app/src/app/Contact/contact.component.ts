import { Component, OnInit } from "@angular/core";
import { IContact } from "../services/IContact";
import { ContactService } from "../services/ContactService";
import { LoginService } from "../services/LoginService";
import { Router } from "@angular/router";

@Component({
    templateUrl:"./contact.component.html"
})
export class ContactComponent implements OnInit{
    contacts:IContact[];
    loggedInUser:string;
    constructor(private _contactService:ContactService,private route:Router,private _loginService:LoginService){
        this.contacts=[];
    }

    ngOnInit() {
        if(this._loginService.getCurrentUser()!=null){
          this.loggedInUser=this._loginService.getCurrentUser().username;
        }
    }
    
    getContacts(){
        return this._contactService.getContacts()
                                .then((resolve)=>{
                                    this.contacts=<IContact[]>resolve;
                                })
                                .catch((reject)=>{
                                    console.log(reject);
                                });
    }

    deleteContact(contact:IContact){
        if(this._loginService.getCurrentUser()==null){
            return this.route.navigate(['/Login']);
        }

        if (confirm(`Are You Sure...!! your want to delete ${contact.contactName} Contact`)) {
            return this._contactService.deleteContact(contact).then((resolve)=>{
                console.log("contact deleted Successfully");
            }).catch((reject)=>{
                console.log("contact deletion Failed");
            });    
        }
    }
}