import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CategoriasService } from 'src/app/services/Categorias.service';

@Component({
  selector: 'app-DialogExclusaoCategoria',
  templateUrl: './DialogExclusaoCategoria.component.html',
  styleUrls: ['./DialogExclusaoCategoria.component.css']
})
export class DialogExclusaoCategoriaComponent {

  constructor(@Inject (MAT_DIALOG_DATA) public dados: any,
  private categoriasService: CategoriasService) { }

  excluirCategoria(categoriaId: number): void{
    this.categoriasService.excluirCategoria(categoriaId)
        .subscribe(resultado => {
             this.dados = resultado;
        });
}


}
