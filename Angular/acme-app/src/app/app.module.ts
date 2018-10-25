import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './Home/welcome.component';
import { from } from 'rxjs';
import { RouteArrays } from './routeConfig';
import { NotFoundComponent } from './NotFound/notFound.component';
import { ProductListComponent } from './ProductList/productList.component';
import { ProductDataService } from './services/ProductDataService';
import { ProductDetailsComponent } from './ProductList/ProductDetail/productDetails.component';
import { StarRatingComponent } from './StarRating/StarRatingComponent';
import { FormsModule } from '@angular/forms';
import {HttpModule} from '@angular/http'

@NgModule({
  declarations: [
    AppComponent,WelcomeComponent,NotFoundComponent,
    ProductListComponent,ProductDetailsComponent,StarRatingComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(RouteArrays)
  ],
  providers: [ProductDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
