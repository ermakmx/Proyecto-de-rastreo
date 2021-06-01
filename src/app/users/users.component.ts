import { Storageservice } from '../services/storage.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  usuarios = [{
    nombre:"Axel",
    rol:"admin",
    contrasena:"***********"
  }]
  constructor(private service:Storageservice) { 
   
  }

  ngOnInit(): void {
  }
  

  clean(){
    this.service.form.reset();
  }
}
