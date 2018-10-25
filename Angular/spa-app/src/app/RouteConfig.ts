import { Routes } from "@angular/router";
import { HomeComponent } from "./Home/home.component";
import { NotFoundComponent } from "./NotFound/notFound.component";
import { AboutComponent } from "./About/about.component";
import { CareerComponent } from "./Career/career.component";
import { ServiceComponent } from "./Services/service.component";

export const RouteArrays: Routes = [
    {
        path: 'Home',
        component: HomeComponent
    },
    {
        path:'About',
        component: AboutComponent
    },
    {
        path:'Career',
        component:CareerComponent
    },
    {
        path:'Service/:id',
        component:ServiceComponent
    },
    {
        path:'Service',
        component:ServiceComponent        
    },
    {
        path: '',
        redirectTo: 'Home',
        pathMatch:'full'
    },
    {
        path: '**',
        component: NotFoundComponent
    }
]