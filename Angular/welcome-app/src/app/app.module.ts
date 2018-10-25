import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpModule } from "@angular/http";

import { WelcomeComponent } from '../swabhav-tech/welcome.component';
import { StudentComponent } from '../swabhav-tech/student/student.component';
import { BlueBox } from '../swabhav-tech/bluebox/bluebox.component';
import { TwoWayComponent } from '../swabhav-tech/twoway/TwoWayComponent';
import { MathService } from '../swabhav-tech/MathService';
import { NumberService } from '../swabhav-tech/NumberService';
import { NumberComponent } from '../swabhav-tech/numbersApi/number.component';
import { QuestionBankService } from '../swabhav-tech/services/questionBankService';
import { QuestionBankComponent } from '../swabhav-tech/questionBank/questionbank.component';
import { SummaryComponent } from 'src/swabhav-tech/SummaryPipe/summary.component';
import { SummaryPipe } from 'src/swabhav-tech/SummaryPipe/SummaryPipe';
import { GenderToColorPipe } from 'src/swabhav-tech/studentApi/GenderToColorPipe';
import { StudentApiComponent } from 'src/swabhav-tech/studentApi/studentApi.component';
import { ParentChildComponent } from 'src/swabhav-tech/ParentChild/ParentChildComponent';
import { ToggleBtnComponent } from 'src/swabhav-tech/ParentChild/ToggleBtn/ToggleBtnComponent';
import { StarRatingComponent } from 'src/swabhav-tech/ParentChild/StarRating/StarRatingComponent';

@NgModule({
  declarations: [
    WelcomeComponent, StudentComponent, BlueBox, TwoWayComponent, NumberComponent, QuestionBankComponent,
    SummaryComponent, SummaryPipe, GenderToColorPipe, StudentApiComponent, ParentChildComponent,
    ToggleBtnComponent,StarRatingComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [MathService, NumberService, QuestionBankService],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
