import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Storageservice } from '../services/storage.service';

@Component({
  selector: 'app-places',
  templateUrl: './places.component.html',
  styleUrls: ['./places.component.css']
})
export class PlacesComponent implements OnInit {

  constructor() { }
  formplaces: FormGroup = new FormGroup({
    $key: new FormControl(null),
    nombre: new FormControl('',[Validators.required]),
    direccion: new FormControl('',[Validators.required]),
    longitud: new FormControl('',[Validators.required]),
    latitud: new FormControl('',[Validators.required])
  })
  ngOnInit(): void {
  }

}
