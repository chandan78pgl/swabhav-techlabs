import { IProduct } from "./IProduct";
import { Http } from "@angular/http";
import { Injectable } from "@angular/core";

@Injectable()
export class ProductDataService{
    constructor(private _http:Http){
        
    }

    getAllProducts(){
        return this._http.get("http://localhost:52486/api/product/AllProducts").toPromise();
    }

    getProductById(id:number){
        return this._http.get(`http://localhost:52486/api/product/ProductDetails/${id}`).toPromise();
    }

    searchProducts(name:string){
        return this._http.get("http://localhost:52486/api/product/SearchProducts/"+name).toPromise();
    }
}