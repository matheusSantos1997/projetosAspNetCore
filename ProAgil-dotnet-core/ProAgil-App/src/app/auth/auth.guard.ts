import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { Observable } from 'rxjs';


@Injectable({
    providedIn: 'root'
  })
  export class AuthGuard implements CanActivate {

    constructor(private router: Router) {}

    canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
      // verifica se existe um token
     if (localStorage.getItem('token') !== null) {
          return true;
      }
      else {
        this.router.navigate(['user/login/']); // redireciona para a pagina de login
        return false;
      }
  }
    
}