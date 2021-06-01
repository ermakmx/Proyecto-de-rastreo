import { PlacesComponent } from './places/places.component';
import { UsersComponent } from './users/users.component';
import { ResourcesComponent } from './resources/resources.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { ReportsComponent } from './reports/reports.component';


const routes: Routes = [
  {path:'home', component:AppComponent},
  {path:'', component:HomeComponent},
  {path:'users', component:UsersComponent},
  {path:'resources', component:ResourcesComponent},
  {path:'places', component:PlacesComponent},
  {path:'reports', component:ReportsComponent},
  {path:'login', component:LoginComponent},
 
];

export const routing = RouterModule.forRoot(routes);
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
