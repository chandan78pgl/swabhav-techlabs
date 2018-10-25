import { Component } from '@angular/core';
import { NavController, Note } from 'ionic-angular';
import { NoteService } from '../../services/NoteService';
import { INote } from '../../services/INote';
import { AddNote } from '../AddNote/addNote';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  isReorderEnabled=false;
  isIconHidden=false;

  constructor(public navCtrl: NavController,private _noteService:NoteService) {

  }

  gotoAdd(){
    this.navCtrl.push(AddNote);
  }

  gotoEditNote(note:INote){
    this.navCtrl.push(AddNote,{
      note:note
    })
  }
  getNotes(){
    return this._noteService.getAll();
  }

  enableReorder(){
    if (!this.isReorderEnabled) {
      this.isIconHidden=true;
      return  this.isReorderEnabled = true;
    }
    setTimeout(()=>this.isIconHidden=false,500);
    return this.isReorderEnabled = false;
  }

  deleteNote(currentNote:INote){
    this._noteService.delete(currentNote);
  }

  reorderItems(indexes){
    console.log(indexes);
    this._noteService.reorder(indexes);
  }
}
