import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  titulo = 'Login';
  model: any = {};

  constructor( private authServices: AuthService,
               public router: Router,
               private toastr: ToastrService) { }

  ngOnInit() {
      // verificando se o localStorage existe o token
      if (localStorage.getItem('token') !== null) {
        this.router.navigate(['/dashboard']); // redireciona para a pagina de dashboard
     }
  }

  login() {
    this.authServices.login(this.model)
      .subscribe(
        () => {
          this.router.navigate(['/dashboard']); // redireciona para a pagina de dashboard
          this.toastr.success('Logado com Sucesso!');
        },
        error => {
          this.toastr.error(`Falha ao tentar Logar, usuário ou senha incorreto ${error}`);
        }
      );
 }

}
