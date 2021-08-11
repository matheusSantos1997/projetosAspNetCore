import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Categoria } from 'src/app/models/Categoria';
import { Tipo } from 'src/app/models/Tipo';
import { CategoriasService } from 'src/app/services/Categorias.service';
import { TiposService } from 'src/app/services/Tipos.service';

@Component({
  selector: 'app-AtualizarCategoria',
  templateUrl: './AtualizarCategoria.component.html',
  styleUrls: ['../ListagemCategorias/ListagemCategorias.component.css']
})
export class AtualizarCategoriaComponent implements OnInit {
  nomeCategoria: string;
  categoriaId: number;
  categoria: Observable<Categoria>;
  tipos: Tipo[];
  formulario: any;

  constructor(private router: Router,
              private route: ActivatedRoute,
              private tiposService: TiposService,
              private categoriasService: CategoriasService) { }

  ngOnInit(): void {
    this.categoriaId = this.route.snapshot.params.id;
     this.tiposService.pegarTodos().subscribe(resultado => {
       this.tipos = resultado;
     });

     // pegando os dados da categoria
     this.categoriasService.pegarCategoriaPeloId(this.categoriaId)
     .subscribe(resultado => {
       this.nomeCategoria = resultado.nome;
        this.formulario = new FormGroup({
           categoriaId: new FormControl(resultado.categoriaId),
           nome: new FormControl(resultado.nome),
           icone: new FormControl(resultado.icone),
           tipoId: new FormControl(resultado.tipoId)
        });
     });
  }

  get propriedade() {
    return this.formulario.controls;
  }

  enviarFormulario(): void {
    const categoria = this.formulario.value;
    this.categoriasService.atualizarCategoria(this.categoriaId, categoria)
                          .subscribe((resultado) => {
                             this.router.navigate(['categorias/listagemcategorias']);
                          })
 }

  voltarListagem(): void{
     this.router.navigate(['categorias/listagemcategorias']);
  }

}
