import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RouterModule} from '@angular/router';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { routeArrays } from './routeConfig';
import { HomeComponent } from './Home/home.component';
import { HttpModule } from '@angular/http';
import { NotFoundComponent } from './NotFound/notFound.component';
import { StudentService } from './Services/StudentService';
import { AddStudentComponent } from './AddStudent/add.component';
import { EditStudentComponent } from './EditStudent/edit.component';

@NgModule({
  declarations: [
    AppComponent,HomeComponent,NotFoundComponent,
    AddStudentComponent,EditStudentComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(routeArrays)
  ],
  providers: [StudentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
