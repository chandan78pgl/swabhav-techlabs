import { INote } from "./INote";
import { reorderArray } from "ionic-angular";

export class NoteService{
    Notes:INote[];
    constructor(){
        // this.Notes=[
        //     {
        //         title:"Edit Items",
        //         description:"This note is for edit items"
        //     },
        //     {
        //         title:"Add Items",
        //         description:"This note is for Add items"
        //     },
        //     {
        //         title:"Reorder Items",
        //         description:"This note is for Reorder items"
        //     },
        //     {
        //         title:"Note Items",
        //         description:"This note is for note items"
        //     }
        // ]

        //this.updateLocalStorage();
        if(localStorage["notes"]!=null){
            this.Notes=JSON.parse(localStorage.getItem("notes"));
            return;
        }
        this.Notes=[];
    }

    getAll(){
        return this.Notes;
    }

    add(newNote:INote){
        this.Notes.push(newNote);
        this.updateLocalStorage();
    }

    reorder(indexes){
        this.Notes=reorderArray(this.Notes,indexes);
        this.updateLocalStorage();
    }

    delete(currentNote:INote){
        for (let index = 0; index < this.Notes.length; index++) {
            if(this.Notes[index].title==currentNote.title){
                this.Notes.splice(index,1);
            }
        }
        this.updateLocalStorage();
    }

    update(currentNote:INote){
        for (let index = 0; index < this.Notes.length; index++) {
            if(this.Notes[index].title==currentNote.title){
                this.Notes[index]=currentNote;
            }
        }
        this.updateLocalStorage();
    }

    updateLocalStorage(){
        localStorage["notes"]=JSON.stringify(this.Notes);
    }
}