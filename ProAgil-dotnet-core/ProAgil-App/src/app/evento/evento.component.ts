import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { defineLocale, ptBrLocale } from 'ngx-bootstrap/chronos';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { Evento } from '../models/Evento';
import { EventoService } from '../services/evento.service';

defineLocale('pt-br', ptBrLocale);

// BsLocaleService, ptBrLocale

@Component({
  selector: 'app-evento',
  templateUrl: './evento.component.html',
  styleUrls: ['./evento.component.css']
})
export class EventoComponent implements OnInit {

   tituloEvento = 'Eventos';
   eventosFiltrados: Evento[];
   eventos: Evento[];
   evento: Evento;
   modoSalvar: string;
   dataEvento: string;

   imagemLargura = 50; // variavel de largura da imagem
   imagemMargem = 2; // variavel de margem da imagem
   mostrarImagem = false;
   // modalRef: BsModalRef;
   registerForm: FormGroup;
   bodyDeletarEvento = '';

   file: File;
   fileNameToUpdate: string;
   dataAtual: string;

   _filtroLista = ''; // propriedade de filtro da lista

  constructor(
    private toastr: ToastrService,
    private eventoService: EventoService,
    private modalService: BsModalService,
    private fb: FormBuilder,
    private localeService: BsLocaleService) {
       this.localeService.use('pt-br');
   }

    // encapsulamento da propriedade _filtroLista
  get filtroLista(): string {
    return this._filtroLista;
 }
 set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista) : this.eventos;
    // vai receber a filtragem do item ou todos os itens
 }

 editarEvento(evento: Evento, template: any) {
      this.modoSalvar = 'put';
      this.openModal(template); // abre o modal
      this.evento = Object.assign({}, evento); // copia as informaçoes
      this.fileNameToUpdate = evento.imagemUrl.toString();
      this.evento.imagemUrl = '';
      this.registerForm.patchValue(this.evento);
 }

 novoEvento(template: any) {
      this.modoSalvar = 'post';
      this.openModal(template);
 }

 // excluir Evento
 excluirEvento(evento: Evento, template: any) {
     this.openModal(template);
     this.evento = evento;
     this.bodyDeletarEvento = `Tem certeza que deseja excluir o Evento: ${evento.tema}, Código: ${evento.id}`;
 }

 confirmeDelete(template: any) {
    this.eventoService.deleteEvento(this.evento.id).subscribe(
       () => {
          template.hide();
          this.getEventos();
          this.toastr.success('Deletado com sucesso!');
        }, error => {
           this.toastr.error(`Erro ao deletar: ${error}`);
           // console.log(error);
        });
}

 openModal(template: any) {
     // this.modalRef = this.modalService.show(template)
     this.registerForm.reset();
     template.show();
 }

   ngOnInit() {
    this.validation();
    this.getEventos();
   }

   filtrarEventos(filtrarPor: string): Evento[] {
    // vai retornar os itens em cada filtragem
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
       (evento) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
}

alternarImagem() {
   this.mostrarImagem = !this.mostrarImagem; // vai fazer com que as imagens suma da tela
}

validation(): void {
     this.registerForm = this.fb.group({
      // validaçoes dos campos
      tema: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]),

      local: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      
      dataEvento: new FormControl('', Validators.required),
      
      qtdPessoas: new FormControl('', [Validators.required, Validators.max(300)]),
      
      imagemUrl: new FormControl('', Validators.required),
      
      telefone: new FormControl('', Validators.required),
      
      email: new FormControl('', [Validators.required, Validators.email])

   });
    // console.log(this.registerForm);
}

onFileChange(event) {
    const reader = new FileReader(); // vai ler a imagem selecionada

    if (event.target.files && event.target.files.length) {
        this.file = event.target.files;
        console.log(this.file);
    }
}

uploadImagem() {

 if (this.modoSalvar === 'post') {
    const nomeArquivo = this.evento.imagemUrl.split('\\', 3);
    this.evento.imagemUrl = nomeArquivo[2]; // [0] = c:/ [1] = folder [2] = nomearquivo

    this.eventoService.postUpload(this.file, nomeArquivo[2]).subscribe(
       () => {
          this.dataAtual = new Date().getMilliseconds().toString();
          this.getEventos(); // recarrega a pagina automaticamente
       }
    );
 } else {
    this.evento.imagemUrl = this.fileNameToUpdate; // mantem o nome na imagem
    this.eventoService.postUpload(this.file, this.fileNameToUpdate).subscribe(
       () => {
          this.dataAtual = new Date().getMilliseconds().toString();
       }
    );
 }
}

// salva as alteraçoes apos inserir novos registros na base de dados
salvarAlteracao(template: any) {
   // verificaçao se o formulário está válidado
   if (this.registerForm.valid) {
      if (this.modoSalvar === 'post') {
        this.evento = Object.assign({}, this.registerForm.value); // vai copiar todos os valores do formulário

        this.uploadImagem();

        this.eventoService.postEvento(this.evento).subscribe(
          (novoEvento: Evento) => {
             console.log(novoEvento);
             template.hide();
             this.getEventos(); // vai atualizar com os novos eventos inseridos
             this.toastr.success('Inserido com sucesso!');
          }, (error) => {
             this.toastr.error(`Erro ao inserir: ${error}`);
             // console.log(error);
          }
       );
      } else {
          this.evento = Object.assign({id: this.evento.id }, this.registerForm.value); // vai copiar todos os valores do formulário

          this.uploadImagem();

          this.eventoService.putEvento(this.evento).subscribe(
          (novoEvento: Evento) => {
          console.log(novoEvento);
          template.hide();
          this.getEventos(); // vai atualizar com os novos eventos inseridos
          this.toastr.success('Editado com sucesso!');
          }, (error) => {
             this.toastr.error(`Erro ao editar: ${error}`);
             // console.log(error);
         }
       );
      }

   }
}

getEventos(): void {
   this.dataAtual = new Date().getMilliseconds().toString();
   /* this.eventos = this.http.get('http://localhost:5000/api/values'); */
   this.dataAtual = new Date().getMilliseconds().toString();
   this.eventoService.getAllEvento().subscribe((eventos: Evento[]) => {
      this.eventos = eventos;
      this.eventosFiltrados = this.eventos;
      console.log(eventos);
    }, error => {
         console.log(error);
      });
}

}
