import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-palestrantes',
  templateUrl: './palestrantes.component.html',
  styleUrls: ['./palestrantes.component.css']
})
export class PalestrantesComponent implements OnInit {

  tituloPalestrantes = 'Palestrantes';

  constructor() { }

  ngOnInit() {
  }

}
