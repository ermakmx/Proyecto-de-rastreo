import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-resources',
  templateUrl: './resources.component.html',
  styleUrls: ['./resources.component.css']
})
export class ResourcesComponent implements OnInit {
  formresources: FormGroup = new FormGroup({
    $key: new FormControl(null),
    nombre: new FormControl('',[Validators.required,Validators.maxLength(30)]),
    tipo: new FormControl('',[Validators.required,Validators.maxLength(30)]),
    activo : new FormControl('',[Validators.required,Validators.maxLength(30)])
    
  })
  constructor() { }

  ngOnInit(): void {
  }
  clean(){
    this.formresources.reset();
  }

}
