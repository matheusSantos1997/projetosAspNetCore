import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Tipo } from '../models/Tipo';

@Injectable({
  providedIn: 'root'
})
export class TiposService {

  url: string = 'https://localhost:5001/api/Tipos';

  // url: string = 'api/Tipos';

constructor(private http: HttpClient) { }

pegarTodos(): Observable<Tipo[]>{
     return this.http.get<Tipo[]>(this.url);
}

}
