import { Component } from "@angular/core";
import { NavController, NavParams } from "ionic-angular";
import { NoteService } from "../../services/NoteService";
import { INote } from "../../services/INote";

@Component({
    templateUrl: './addNote.html'
})
export class AddNote {
    title: string;
    description: string;
    navHeading:string;

    constructor(public navCtrl: NavController,private _navParams:NavParams, private _noteService: NoteService) {
       this.navHeading="Add Note";
        if (_navParams.get("note")!=null) {
           this.navHeading="Edit Note";
       }

       let note =<INote>Object.assign({},_navParams.get("note"));
       this.title=note.title;
       this.description=note.description;
    }

    save() {
        let note: INote;

        note = {
            title: this.title,
            description: this.description
        }

        if (this._navParams.get("note")!=null) {
           return this.edit(note);
        }
        this._noteService.add(note);
        this.navCtrl.pop();
    }

    edit(note:INote){
        this._noteService.update(note);
        this.navCtrl.pop();
    }
}