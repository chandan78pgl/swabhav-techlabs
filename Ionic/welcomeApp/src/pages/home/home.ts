import { Component } from '@angular/core';
import { NavController, MenuController } from 'ionic-angular';
import { About } from '../about/about';
import { Career } from '../career/career';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

 
  rootPage;
  aboutPage;
  message = "welcome to ionic App";
  constructor(public navCtrl: NavController,public menuCtrl:MenuController) {
    this.rootPage=Career;
    this.aboutPage=About;
  }

  openPage(p){
    console.log(p);
    this.rootPage=p;
  }

  closeMenu(){
    this.menuCtrl.close();
  }
}
