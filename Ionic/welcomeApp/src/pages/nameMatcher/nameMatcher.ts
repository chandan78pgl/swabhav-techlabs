import { Component} from "@angular/core";
import {Contacts} from '@ionic-native/contacts';

@Component({
    templateUrl: './nameMatcher.html',
    selector : 'page-nameMatcher'
})
export class NameMatcher{

    firstPersonName:string;
    secondPersonName:string;
    matchPercentage = 0;
    
    pickedContact:string;

    constructor(private _contacts:Contacts){
        this.pickedContact = "Chandan";
    }

    pickContact(name){
        this._contacts.pickContact().then((contact)=>{
            this.pickedContact=contact.displayName;
            if (name=='first') {
                this.firstPersonName=this.pickedContact;
                return this.foundMatchingPercent();
            }
            this.secondPersonName=this.pickedContact;
            return this.foundMatchingPercent();
        });  
    }

    foundMatchingPercent(){
        if((this.firstPersonName!=null && this.firstPersonName!="") && (this.secondPersonName!=null && this.secondPersonName!="")){
            this.matchPercentage=0;
            let match = this.firstPersonName.concat(this.secondPersonName);
            
            for (let index = 0; index < match.length; index++) {
                this.matchPercentage += match.charCodeAt(index);
            }

            return this.matchPercentage%=101;
        }
        return this.matchPercentage=0;
    }
}