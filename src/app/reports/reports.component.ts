import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reports',
  templateUrl: './reports.component.html',
  styleUrls: ['./reports.component.css']
})
export class ReportsComponent implements OnInit {
  formreports: FormGroup = new FormGroup({
    $key: new FormControl(null),
    nombre: new FormControl('',[Validators.required,Validators.maxLength(30)]),
    detallereporte: new FormControl('',[Validators.required,Validators.maxLength(100)]),
    fecha : new FormControl('',[Validators.required,Validators.maxLength(12)])
    
  })
  constructor() { }

  ngOnInit(): void {
  }

  clean(){
    this.formreports.reset();
  }
}
