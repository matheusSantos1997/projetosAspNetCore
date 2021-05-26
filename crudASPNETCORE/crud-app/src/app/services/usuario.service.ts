import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../model/Usuario';

@Injectable({
    providedIn: 'root'
  })

export class UsuarioService {

    baseURL = 'http://localhost:5000/api/usuario';

constructor(private http: HttpClient) { }

  getAllUsuario(): Observable<Usuario[]> {
      return this.http.get<Usuario[]>(this.baseURL);
  }

  getUsuarioById(idUsuario: number): Observable<Usuario[]> {
    return this.http.get<Usuario[]>(`${this.baseURL}/${idUsuario}`);
   }

   // tslint:disable-next-line: typedef
   postUsuario(usuario: Usuario) {
    return this.http.post(`${this.baseURL}`, usuario);
 }

 // tslint:disable-next-line: typedef
 putUsuario(usuario: Usuario) {
    return this.http.put(`${this.baseURL}/${usuario.idUsuario}`, usuario);
 }

 // tslint:disable-next-line: typedef
 deleteUsuario(idUsuario: number) {
    return this.http.delete(`${this.baseURL}/${idUsuario}`);
 }

}
