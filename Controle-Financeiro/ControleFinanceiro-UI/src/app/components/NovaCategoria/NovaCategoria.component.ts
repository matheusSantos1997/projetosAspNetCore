import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Tipo } from 'src/app/models/Tipo';
import { CategoriasService } from 'src/app/services/Categorias.service';
import { TiposService } from 'src/app/services/Tipos.service';

@Component({
  selector: 'app-NovaCategoria',
  templateUrl: './NovaCategoria.component.html',
  styleUrls: ['../ListagemCategorias/ListagemCategorias.component.css']
})
export class NovaCategoriaComponent implements OnInit {

  formulario: any;
  tipos: Tipo[];

  constructor(private tiposServices: TiposService,
              private categoriasSevices: CategoriasService,
              private router: Router) { }

  ngOnInit(): void {
     this.tiposServices.pegarTodos().subscribe(resultado => {
       this.tipos = resultado;
       console.log(resultado);
     });

     this.formulario = new FormGroup({
         nome: new FormControl(null),
         icone: new FormControl(null),
         tipoId: new FormControl(null),
     });
  }

  get propriedade() {
     return this.formulario.controls;
  }

  // sava formulario
  enviarFormulario(): void{
     const categoria = this.formulario.value;

     this.categoriasSevices.novaCategoria(categoria)
                           .subscribe(resultado => {
           this.router.navigate(['categorias/listagemcategorias']);
     })
  }

  voltarListagem(): void{
    this.router.navigate(['categorias/listagemcategorias']);
 }

}
