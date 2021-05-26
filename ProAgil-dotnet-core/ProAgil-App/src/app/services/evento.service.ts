import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Evento } from '../models/Evento';

@Injectable()
export class EventoService {

    baseURL = 'http://localhost:5000/api/evento';
    // tokenHeader: HttpHeaders;

constructor(private http: HttpClient) {
    // this.tokenHeader = new HttpHeaders({'Authorization': `Bearer ${localStorage.getItem('token')}`});
}

getAllEvento(): Observable<Evento[]> {
    const tokenHeader = new HttpHeaders({ 'Authorization': `Bearer ${localStorage.getItem('token')}` });
    return this.http.get<Evento[]>(this.baseURL); // { headers: this.tokenHeader }
 }

  getEventoByTema(tema: string): Observable<Evento[]> {
  return this.http.get<Evento[]>(`${this.baseURL}/getByTema/${tema}`);
}

getEventoById(id: number): Observable<Evento> {
 return this.http.get<Evento>(`${this.baseURL}/${id}`);
}

postUpload(file: File, name: string) {
   // tslint:disable-next-line: no-angle-bracket-type-assertion
   const fileToUpload = <File> file[0];
   const formData = new FormData();
   formData.append('file', fileToUpload, name);

   return this.http.post(`${this.baseURL}/upload`, formData); // { headers: this.tokenHeader }
}

// recebimento via POST dos formuláios
postEvento(evento: Evento) {
   return this.http.post(`${this.baseURL}`, evento); // { headers: this.tokenHeader}
}

putEvento(evento: Evento) {
   return this.http.put(`${this.baseURL}/${evento.id}`, evento); // { headers: this.tokenHeader}
}

deleteEvento(id: number) {
   return this.http.delete(`${this.baseURL}/${id}`); // { headers: this.tokenHeader }
}

}
