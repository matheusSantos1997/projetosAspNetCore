import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AtualizarCategoriaComponent } from './components/AtualizarCategoria/AtualizarCategoria.component';
import { ListagemCategoriasComponent } from './components/ListagemCategorias/ListagemCategorias.component';
import { NovaCategoriaComponent } from './components/NovaCategoria/NovaCategoria.component';

const routes: Routes = [
  { path: 'categorias/listagemcategorias', component: ListagemCategoriasComponent },
  { path: 'categorias/novacategoria', component: NovaCategoriaComponent },
  { path: 'categorias/atualizarcategoria/:id', component: AtualizarCategoriaComponent },
  { path: '', pathMatch: 'full', redirectTo: 'categorias/listagemcategorias'},
  { path: '**', redirectTo: 'categorias/listagemcategorias' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
