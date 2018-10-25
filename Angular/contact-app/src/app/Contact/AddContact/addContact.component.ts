import { Component } from "@angular/core";
import { ContactService } from "src/app/services/ContactService";
import { Router } from "@angular/router";
import { IContact } from "src/app/services/IContact";
import { injectComponentFactoryResolver } from "@angular/core/src/render3";

@Component({
    templateUrl:'./addContact.component.html'
})
export class AddContactComponent{
    
    contactName:string;
    contactNumber:number;

    constructor(private route:Router,private _contactService:ContactService){
    }

    addContact(){
        let contact:IContact;
        
        contact ={
            contactName:this.contactName,
            mobileNumber:this.contactNumber
        }

        this._contactService.addContact(contact).then((resolve)=>{
            console.log("contact Added Successfully");
        }).catch((reject)=>{
            console.log("contact Added Failed");
        });
        this.route.navigate(['/Contact']);
    }
}