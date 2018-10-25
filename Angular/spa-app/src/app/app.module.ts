import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import {RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { RouteArrays } from './RouteConfig';
import { HomeComponent } from './Home/home.component';
import { NotFoundComponent } from './NotFound/notFound.component';
import { AboutComponent } from './About/about.component';
import { CareerComponent } from './Career/career.component';
import { ServiceComponent } from './Services/service.component';

@NgModule({
  declarations: [
    AppComponent,HomeComponent,NotFoundComponent,AboutComponent,CareerComponent,
    ServiceComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(RouteArrays)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
