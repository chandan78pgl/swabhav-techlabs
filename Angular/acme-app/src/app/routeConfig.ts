import { Routes } from "@angular/router";
import { WelcomeComponent } from "./Home/welcome.component";
import { NotFoundComponent } from "./NotFound/notFound.component";
import { ProductListComponent } from "./ProductList/productList.component";
import { ProductDetailsComponent } from "./ProductList/ProductDetail/productDetails.component";

export const RouteArrays:Routes=[
    {
        path:'ProductList/ProductDetails/:id',
        component:ProductDetailsComponent
    },
    {
        path:'ProductList',
        component:ProductListComponent
    },
    {
        path:'Welcome',
        component:WelcomeComponent
    },
    {
        path:'',
        redirectTo:'Welcome',
        pathMatch:'full'
    },
    {
        path:'**',
        component:NotFoundComponent
    }
]