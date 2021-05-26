import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { ToastrService } from 'ngx-toastr';
import { Evento } from 'src/app/models/Evento';
import { EventoService } from 'src/app/services/evento.service';

@Component({
  selector: 'app-eventoEdit',
  templateUrl: './eventoEdit.component.html',
  styleUrls: ['./eventoEdit.component.css']
})
export class EventoEditComponent implements OnInit {

  titulo = 'Editar Evento';
  evento: Evento = new Evento();
  imgArrowWidth = 50;
  imgArrowMarge = 2;
  imagemUrl = 'assets/img/upload.png';
  registerForm: FormGroup;
  file: File;
  dataEvento: string;
  fileNameToUpdate: string;
  dataAtual = '';

  // retorna todos os Lotes
  get lotes(): FormArray {
    return this.registerForm.get('lotes') as FormArray;
  }

  // retorna todas as Redes sociais
  get redesSociais(): FormArray {
     return this.registerForm.get('redesSociais') as FormArray;
  }

  constructor(private toastr: ToastrService,
              private eventoService: EventoService,
              private fb: FormBuilder,
              private router: ActivatedRoute,
              private route: Router,
              private localeService: BsLocaleService) {
                  this.localeService.use('pt-br');
              }

  ngOnInit() {
     this.validation();
     this.carregarEvento();
  }

  carregarEvento() {
    const idEvento = +this.router.snapshot.paramMap.get('id'); // + converte uma string para number
      // tslint:disable-next-line:align
      this.eventoService.getEventoById(idEvento)
       // tslint:disable-next-line: deprecation
       .subscribe((evento: Evento) => {
           this.evento = Object.assign({}, evento);
           this.fileNameToUpdate = evento.imagemUrl.toString();
           this.imagemUrl = `http://localhost:5000/Resources/images/${this.evento.imagemUrl}?_ts=${this.dataAtual}`;
           this.evento.imagemUrl = '';
           this.registerForm.patchValue(this.evento);

           this.evento.lotes.forEach(lote => {
              this.lotes.push(this.criaLote(lote));
           });

           this.evento.redesSociais.forEach(redeSocial => {
              this.redesSociais.push(this.criaRedeSocial(redeSocial));
           });
         }
       );
  }

  validation() {
    this.registerForm = this.fb.group({
     id: [],
     // validaçoes dos campos
     tema: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
     
     local: ['', [Validators.required, Validators.maxLength(30)]],
     
     dataEvento: ['', Validators.required],
     
     qtdPessoas: ['', [Validators.required, Validators.max(300)]],
     
     imagemUrl: [''],
     
     telefone: ['', Validators.required],
     
     email: ['', [Validators.required, Validators.email]],

     // this.fb.array vai permitir que seje adicionado uma lista de lotes
     lotes: this.fb.array([]),
     // this.fb.array vai permitir que seja adicionado uma lista de redes sociais
     redesSociais: this.fb.array([])

  });
    // console.log(this.registerForm);
}

  criaLote(lote: any): FormGroup {
       return this.fb.group({
              id: [lote.id],
              nome: [lote.nome, Validators.required],
              quantidade: [lote.quantidade, Validators.required],
              preco: [lote.preco, Validators.required],
              dataInicio: [lote.dataInicio],
              dataFim: [lote.dataFim]
         });
  }

  criaRedeSocial(redeSocial: any): FormGroup {
      return this.fb.group({
        id: [redeSocial.id],
        nome: [redeSocial.nome, Validators.required],
        url: [redeSocial.url, Validators.required]
      });
  }

  adicionarLote() {
    this.lotes.push(this.criaLote({ id: 0 }));
  }

  adicionarRedeSocial() {
      this.redesSociais.push(this.criaRedeSocial({ id: 0 }));
  }

  removerLote(id: number) {
    this.lotes.removeAt(id);
 }

 removerRedeSocial(id: number) {
    this.redesSociais.removeAt(id);
 }

  onFileChange(evento: any, file: FileList) {
      const reader = new FileReader();

      // carrega e troca a imagem apos seleciona-la
      reader.onload = (event: any) => this.imagemUrl = event.target.result;
      this.file = evento.target.files;
      reader.readAsDataURL(file[0]);
  }

  salvarEvento() {
       this.evento = Object.assign({ id: this.evento.id }, this.registerForm.value); // vai copiar todos os valores do formulário
       this.evento.imagemUrl = this.fileNameToUpdate;
       this.uploadImagem();

       // tslint:disable-next-line: deprecation
       this.eventoService.putEvento(this.evento).subscribe(
    () => {
    this.toastr.success('Editado com sucesso!');
    }, (error) => {
       this.toastr.error(`Erro ao editar: ${error}`);
       // console.log(error);
      }
    );
  }

  uploadImagem() {
     if (this.registerForm.get('imagemUrl').value !== '') {
        this.eventoService.postUpload(this.file, this.fileNameToUpdate)
        // tslint:disable-next-line: deprecation
        .subscribe(
        () => {
          this.dataAtual = new Date().getMilliseconds().toString();
          location.reload();
          this.imagemUrl = `http://localhost:5000/Resources/images/${this.evento.imagemUrl}?_ts=${location.reload()}`;
       }
    );

     }

  }

  // botao voltar para todos os eventos em geral
  backToGeneralEvents(): void {
      this.route.navigate(['/evento']);
  }


}
