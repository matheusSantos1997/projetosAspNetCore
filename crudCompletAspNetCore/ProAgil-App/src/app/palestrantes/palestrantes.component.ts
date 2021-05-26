import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-palestrantes',
  templateUrl: './palestrantes.component.html',
  styleUrls: ['./palestrantes.component.scss']
})
export class PalestrantesComponent implements OnInit {

  tituloPalestrantes = 'Palestrantes';

  constructor() { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
  }

}
