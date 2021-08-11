import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria } from '../models/Categoria';

// congigurando o cabeçalho da requisiçao http para enviar dados para a api
const httpOptions = {
   headers: new HttpHeaders ({
      'Content-Type': 'application/json'
   })
};

@Injectable({
  providedIn: 'root'
})
export class CategoriasService {

  url: string = 'https://localhost:5001/api/categorias';

  // // url: string = 'api/Categorias';

constructor(private http: HttpClient) { }

pegarTodos(): Observable<Categoria[]>{
   return this.http.get<Categoria[]>(this.url);
}

pegarCategoriaPeloId(categoriaId: number): Observable<Categoria>{
   const apiUrl = `${this.url}/${categoriaId}`;

   return this.http.get<Categoria>(apiUrl);
}

novaCategoria(categoria: Categoria): Observable<any>{
    return this.http.post<Categoria>(this.url, categoria, httpOptions);
}

atualizarCategoria(categoriaId: number, categoria: Categoria): Observable<any>{
    const apiUrl = `${this.url}/${categoriaId}`;

    return this.http.put<Categoria>(apiUrl, categoria, httpOptions);
}

excluirCategoria(categoriaId: number): Observable<any> {
    const apiUrl = `${this.url}/${categoriaId}`;
    return this.http.delete<number>(apiUrl, httpOptions);
}

// filtrar categorias
filtrarCategorias(nomeCategoria: string): Observable<Categoria[]>{
   const apiUrl = `${this.url}/FiltrarCategorias/${nomeCategoria}`;
   return this.http.get<Categoria[]>(apiUrl);
}

}
