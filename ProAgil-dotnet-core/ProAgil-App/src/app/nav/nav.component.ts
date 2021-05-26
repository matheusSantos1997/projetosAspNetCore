import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  constructor(
        public authService: AuthService,
        public router: Router,
        private toastr: ToastrService) { }

  ngOnInit() {
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  entrar() {
    this.router.navigate(['/user/login']);
  }

  // deslogar da sessao
  logout() {
    localStorage.removeItem('token'); // remove o token gerado quando estiver logado
    this.toastr.show('Log Out');
    this.router.navigate(['/user/login']);
   }

   showMenu(): boolean {
      return this.router.url !== '/user/login';
    }

    userName() {
       return sessionStorage.getItem('username');
    }

}
