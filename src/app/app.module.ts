import { Storageservice } from './services/storage.service';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './login/login.component';
import { RouterModule} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ReportsComponent } from './reports/reports.component';
import { ResourcesComponent } from './resources/resources.component';
import { PlacesComponent } from './places/places.component';
import { UsersComponent } from './users/users.component';
import { MatToolbarModule} from '@angular/material/toolbar';
import { MatSidenavModule} from '@angular/material/sidenav';
import { MatButtonModule} from '@angular/material/button';
import { MatIconModule} from '@angular/material/icon';
import { MatDividerModule} from '@angular/material/divider';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatCardModule} from '@angular/material/card';

  
import { HttpClientModule, HttpClient } from '@angular/common/http';  
 
import { MatDatepickerModule } from '@angular/material/datepicker';  
import { MatMenuModule } from '@angular/material/menu';  
import { MatNativeDateModule } from '@angular/material/core';   
import { MatTooltipModule } from '@angular/material/tooltip';  

import { MatRadioModule } from '@angular/material/radio';  
  
    
import { MatCheckboxModule } from '@angular/material/checkbox';  
import { MatSelectModule } from '@angular/material/select';  
import { MatSnackBarModule } from '@angular/material/snack-bar';  
import { MatTableModule } from '@angular/material/table';  
import { CdkTableModule } from '@angular/cdk/table';  
import { MatPaginatorModule } from '@angular/material/paginator';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    ReportsComponent,
    ResourcesComponent,
    PlacesComponent,
    UsersComponent,
   
   
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    RouterModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatButtonModule,
    MatIconModule,
    MatDividerModule,
    MatFormFieldModule,
    MatInputModule,
    ReactiveFormsModule,
    MatGridListModule,
    MatCardModule,
    BrowserModule,  
    FormsModule,  
    ReactiveFormsModule,  
    HttpClientModule,  
    BrowserAnimationsModule,  
    MatButtonModule,  
    MatMenuModule,  
    MatDatepickerModule,  
    MatNativeDateModule,  
    MatIconModule,  
    MatRadioModule,  
    MatCardModule,  
    MatSidenavModule,  
    MatFormFieldModule,  
    MatInputModule,  
    MatTooltipModule,  
    MatToolbarModule,  
    AppRoutingModule,  
    MatCheckboxModule,  
    MatSelectModule,  
    MatSnackBarModule,  
    MatTableModule,  
    CdkTableModule,  
    MatPaginatorModule  
    
  
  
  ],
  providers: [Storageservice],
  bootstrap: [AppComponent]
})
export class AppModule { }
