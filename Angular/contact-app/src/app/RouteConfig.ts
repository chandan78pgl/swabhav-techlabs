import { Routes } from "@angular/router";
import { HomeComponent } from "./Home/home.component";
import { NotFoundComponent } from "./NotFound/notFound.component";
import { ContactComponent } from "./Contact/contact.component";
import { AddContactComponent } from "./Contact/AddContact/addContact.component";
import { EditComponent } from "./Contact/EditContact/edit.component";
import { LoginComponent } from "./Login/login.component";

export const RouteArrays:Routes=[
    {
        path: 'Home',
        component: HomeComponent
    },
    {
        path:'Edit',
        component:EditComponent
    },
    {
        path: 'Contact',
        component:ContactComponent
    },
    {
        path: 'AddContact',
        component:AddContactComponent
    },
    {
        path: 'Login',
        component:LoginComponent
    },
    {
        path: '',
        redirectTo: 'Home',
        pathMatch:'prefix'
    },
    {
        path: '**',
        component: NotFoundComponent
    }
]