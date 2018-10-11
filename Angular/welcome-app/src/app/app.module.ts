import { BrowserModule } from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpModule } from "@angular/http";

import { WelcomeComponent } from '../swabhav-tech/welcome.component';
import { StudentComponent } from '../swabhav-tech/student/student.component';
import { BlueBox } from '../swabhav-tech/bluebox/bluebox.component';
import { TwoWayComponent } from '../swabhav-tech/twoway/TwoWayComponent';
import { MathService } from '../swabhav-tech/MathService';
import { NumberService } from '../swabhav-tech/NumberService';
import { NumberComponent } from '../swabhav-tech/numbersApi/number.component';

@NgModule({
  declarations: [
    WelcomeComponent, StudentComponent,BlueBox,TwoWayComponent,NumberComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [MathService,NumberService],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }