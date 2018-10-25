import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import {RouterModule} from '@angular/router';
import { AppComponent } from './app.component';
import { RouteArrays } from './RouteConfig';
import { HomeComponent } from './Home/home.component';
import { NotFoundComponent } from './NotFound/notFound.component';
import { ContactComponent } from './Contact/contact.component';
import { ContactService } from './services/ContactService';
import { AddContactComponent } from './Contact/AddContact/addContact.component';
import { EditComponent } from './Contact/EditContact/edit.component';
import { LoginService } from './services/LoginService';
import { LoginComponent } from './Login/login.component';

@NgModule({
  declarations: [
    AppComponent,HomeComponent,NotFoundComponent,ContactComponent,AddContactComponent,
    EditComponent,LoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(RouteArrays)
  ],
  providers: [ContactService,LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
