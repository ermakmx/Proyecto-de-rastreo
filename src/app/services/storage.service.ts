import { Injectable } from '@angular/core';
import { FormGroup, FormControl,Validators } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class Storageservice {

  constructor() { }
  form: FormGroup = new FormGroup({
    $key: new FormControl(null),
    fullname: new FormControl('',[Validators.required,Validators.maxLength(30)]),
    password: new FormControl('',[Validators.required,Validators.maxLength(23)]),
    role: new FormControl('',[Validators.maxLength(23)])
    
  });
  
}
