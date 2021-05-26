import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { BsModalService } from 'ngx-bootstrap/modal';
import { Usuario } from '../model/Usuario';
import { UsuarioService } from '../services/usuario.service';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {

   usuarios: Usuario[];
   usuario: Usuario;
   modoSalvar: string;

   registerForm: FormGroup;
   bodyDeletarEvento = '';

  constructor(
    private usuarioService: UsuarioService,
    private fb: FormBuilder,
    ) { }

  // tslint:disable-next-line: typedef
  ngOnInit() {
      this.getUsuarios();
      this.validation();
  }

// tslint:disable-next-line: typedef
openModal(template: any) {
  // this.modalRef = this.modalService.show(template)
  this.registerForm.reset();
  template.show();
}

// tslint:disable-next-line: typedef
novoUsuario(template: any) {
    this.modoSalvar = 'post';
    this.openModal(template);
}

// tslint:disable-next-line: typedef
editarUsuario(usuario: Usuario, template: any) {
  this.modoSalvar = 'put';
  this.openModal(template);
  this.usuario = usuario;
  this.registerForm.patchValue(usuario);
}

// excluir Evento
// tslint:disable-next-line: typedef
excluirUsuario(usuario: Usuario, template: any) {
 this.openModal(template);
 this.usuario = usuario;
 this.bodyDeletarEvento = `Tem certeza que deseja excluir o Usuario: ${usuario.nome}, Código: ${usuario.idUsuario}`;
}

// tslint:disable-next-line: typedef
confirmeDelete(template: any) {
this.usuarioService.deleteUsuario(this.usuario.idUsuario).subscribe(
   () => {
      template.hide();
      this.getUsuarios();
    }, error => {
       console.log(error);
    });
}

// salva as alteraçoes apos inserir novos registros na base de dados
  // tslint:disable-next-line: typedef
  salvarAlteracao(template: any) {
    // verificaçao se o formulário está válidado
    if (this.registerForm.valid) {
       if (this.modoSalvar === 'post') {
         this.usuario = Object.assign({}, this.registerForm.value); // vai copiar todos os valores do formulário
         this.usuarioService.postUsuario(this.usuario).subscribe(
           (novoUsuario: Usuario) => {
              console.log(novoUsuario);
              template.hide();
              this.getUsuarios(); // vai atualizar com os novos eventos inseridos
           }, (error) => {
              console.log(error);
           }
        );
       } else {
           // tslint:disable-next-line: max-line-length
           this.usuario = Object.assign({idUsuario: this.usuario.idUsuario }, this.registerForm.value); // vai copiar todos os valores do formulário
           this.usuarioService.putUsuario(this.usuario).subscribe(
           (novoUsuario: Usuario) => {
           console.log(novoUsuario);
           template.hide();
           this.getUsuarios(); // vai atualizar com os novos eventos inseridos
           }, (error) => {
           console.log(error);
          }
        );
       }

    }
 }

getUsuarios(): void {
     this.usuarioService.getAllUsuario().subscribe((usuarios: Usuario[]) => {
       this.usuarios = usuarios;
       console.log(usuarios);
     }, error => {
       console.log(error);
     });
  }

  validation(): void {
    this.registerForm = this.fb.group({
      nome: new FormControl('', Validators.required),
      // tslint:disable-next-line: new-parens
      email: new FormControl('', Validators.required),
      // tslint:disable-next-line: new-parens
      telefone: new FormControl('', Validators.required)
    });
    console.log(this.registerForm);
}


}
