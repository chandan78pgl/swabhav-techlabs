import { Component, OnInit } from "@angular/core";
import { ContactService } from "src/app/services/ContactService";
import { IContact } from "src/app/services/IContact";
import { Router, ActivatedRoute } from "@angular/router";
import { LoginService } from "src/app/services/LoginService";

@Component({
    templateUrl: './edit.component.html',
})
export class EditComponent implements OnInit {

    name: string;
    mobileNumber: number;
    constructor(private _contactService: ContactService,
        private route: Router,
        private routes: ActivatedRoute,
        private _loginService: LoginService
    ) {
        this.routes.queryParams.subscribe(params => {
            this.name = params.name
            if (this.name != undefined) {
                this.mobileNumber = _contactService.getContact(this.name).mobileNumber;
            }
        });

    }

    ngOnInit() {
        if (this._loginService.getCurrentUser() == null) {
            return this.route.navigate(['/Login']);
        }
    }

    editContact() {
        let contact: IContact;
        contact = {
            contactName: this.name,
            mobileNumber: this.mobileNumber
        }
        this._contactService.editContact(contact)
            .then((resolve) => {
                console.log("contact Updated Successfully");
            }).catch((reject) => {
                console.log("contact Updation Failed");
            });;
        this.route.navigate(['Contact']);
    }
}