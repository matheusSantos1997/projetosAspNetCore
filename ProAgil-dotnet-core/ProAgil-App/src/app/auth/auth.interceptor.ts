import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { tap } from 'rxjs/internal/operators/tap';

@Injectable({
    providedIn: 'root'
})

export class AuthInterceptor implements HttpInterceptor {

    constructor(private router: Router) {}

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // throw new Error('Method not implemented.');
        if (localStorage.getItem('token') !== null) {
          const cloneReq = req.clone({
             headers: req.headers.set('Authorization', `Bearer ${localStorage.getItem('token')}`)
          });
          return next.handle(cloneReq).pipe(
              tap(
                 (success) => {},
                 (error) => {
                     if (error.status === 401) {
                         this.router.navigateByUrl('user/login');
                     }
                 }
              )
          );
        } else {
            return next.handle(req.clone());
        }
    }

}