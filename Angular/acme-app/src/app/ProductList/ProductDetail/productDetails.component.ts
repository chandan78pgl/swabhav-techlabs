import { Component, OnInit } from "@angular/core";
import { IProduct } from "src/app/services/IProduct";
import { ProductDataService } from "src/app/services/ProductDataService";
import { ActivatedRoute } from "@angular/router";

@Component({
    templateUrl:'./productDetails.component.html'
})
export class ProductDetailsComponent{
    product = {};
    productId:number;
    starRating:number = 1;

    constructor(private _productDataService:ProductDataService,private _routes:ActivatedRoute){
        this._routes.params.subscribe((param)=>{
            this.productId=param.id;
        });

        this._productDataService.getProductById(this.productId).then((response)=>{
            this.product=response.json();
        });
    }
}