import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contatos',
  templateUrl: './contatos.component.html',
  styleUrls: ['./contatos.component.scss']
})
export class ContatosComponent implements OnInit {

  tituloContatos = 'Contatos';

  constructor() { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
  }

}
