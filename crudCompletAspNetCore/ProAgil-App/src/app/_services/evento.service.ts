import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Evento } from '../_models/Evento';

@Injectable({
  providedIn: 'root'
})
export class EventoService {
 baseURL = 'http://localhost:5000/api/evento';

 constructor(private http: HttpClient) { }

 getAllEvento(): Observable<Evento[]> {
    return this.http.get<Evento[]>(this.baseURL);
 }

  getEventoByTema(tema: string): Observable<Evento[]> {
  return this.http.get<Evento[]>(`${this.baseURL}/getByTema/${tema}`);
}

getEventoById(id: number): Observable<Evento[]> {
 return this.http.get<Evento[]>(`${this.baseURL}/${id}`);
}

// tslint:disable-next-line: typedef
postUpload(file: File, name: string) {
   // tslint:disable-next-line: no-angle-bracket-type-assertion
   const fileToUpload = <File> file[0];
   const formData = new FormData();
   formData.append('file', fileToUpload, name);

   return this.http.post(`${this.baseURL}/upload`, formData);
}

// recebimento via POST dos formuláios
// tslint:disable-next-line: typedef
postEvento(evento: Evento) {
   return this.http.post(`${this.baseURL}`, evento);
}

// tslint:disable-next-line: typedef
putEvento(evento: Evento) {
   return this.http.put(`${this.baseURL}/${evento.id}`, evento);
}

// tslint:disable-next-line: typedef
deleteEvento(id: number) {
   return this.http.delete(`${this.baseURL}/${id}`);
}

}
