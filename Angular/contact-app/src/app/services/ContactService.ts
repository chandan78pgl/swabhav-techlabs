import { IContact } from "./IContact";

export class ContactService{
    Contacts:IContact[];

    constructor(){
        this.Contacts = [];

        this.Contacts.push({
            contactName:"Chandan",
            mobileNumber:8460551251
        });
        this.Contacts.push({
            contactName:"Dharmesh",
            mobileNumber:8780421011
        });
    }

    getContacts(){
        return new Promise((resolve,reject)=>{
            if (this.Contacts!=null) {
                return resolve(this.Contacts);
            }
            return reject("No data available");
        });
    }

    addContact(contact:IContact){
        return new Promise((resolve,reject)=>{
            if (contact!=null) {
                this.Contacts.push(contact);
                return resolve(true);
            }
            return reject(false);
        });
        
    }

    getContact(name:string):IContact{
        for (const contact of this.Contacts) {
            if(contact.contactName==name){
                return contact;
            }
        }
        return null;
    }

    editContact(contact:IContact){
        return new Promise((resolve,reject)=>{
            for(let i=0;i<this.Contacts.length;i++){
                if(this.Contacts[i].contactName==contact.contactName){
                    this.Contacts[i]=contact;
                    return resolve(true);
                }
            }

            return reject(false);
        });
    }

    deleteContact(contact:IContact){
        return new Promise((resolve,reject)=>{
            for(let i=0;i<this.Contacts.length;i++){
                if(this.Contacts[i].contactName==contact.contactName){
                    this.Contacts.splice(i,1);
                    return resolve(true);
                }
            }
            return reject(false);
        });
    }
}