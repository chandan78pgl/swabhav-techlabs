import { Component } from "@angular/core";
import { IProduct } from "../services/IProduct";
import { ProductDataService } from "../services/ProductDataService";

@Component ({
    templateUrl:'./productList.component.html'
})
export class ProductListComponent{
    Products:IProduct[];
    imageShow:boolean;
    btnText:string;
    searchString:string;

    constructor(private _productDataService:ProductDataService){
        _productDataService.getAllProducts().then((response)=>{
            this.Products=response.json();
            this.imageShow=true;
            
        });
        
        this.btnText="Show Image";
    }

    showImage(){
        if(!this.imageShow){
            this.btnText="Show Image";
            return this.imageShow=true;
        }
        this.btnText="Hide Image";
        return this.imageShow=false;
    }

    searchProducts(){
        
        if(this.searchString!=""){
            this._productDataService.searchProducts(this.searchString).then((response)=>{
                console.log(response);
                this.Products = response.json();
            });
            return;
        }
        return this._productDataService.getAllProducts().then((response)=>{
            this.Products=response.json();            
        });
    }
}