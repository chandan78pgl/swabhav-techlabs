import { Routes } from "@angular/router";
import { HomeComponent } from "./Home/home.component";
import { NotFoundComponent } from "./NotFound/notFound.component";
import { AddStudentComponent } from "./AddStudent/add.component";
import { EditStudentComponent } from "./EditStudent/edit.component";

export const routeArrays:Routes=[
    {
        path: 'Home',
        component: HomeComponent
    },
    {
        path: 'Add',
        component:AddStudentComponent
    },
    {
        path: 'Edit/:id',
        component:EditStudentComponent
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
];