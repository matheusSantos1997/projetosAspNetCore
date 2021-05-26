import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule } from 'ngx-bootstrap/modal';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { AppComponent } from './app.component';
import { EventoComponent } from './evento/evento.component';
import { NavComponent } from './nav/nav.component';
import { DateTimeFormatPipePipe } from './_helps/DateTimeFormatPipe.pipe';
import { EventoService } from './_services/evento.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ContatosComponent } from './contatos/contatos.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { TituloComponent } from './_shared/titulo/titulo.component';
import { AppRoutingModule } from './app-routing.module';


@NgModule({
  declarations: [
    AppComponent,
      EventoComponent,
      NavComponent,
      DateTimeFormatPipePipe,
      DashboardComponent,
      ContatosComponent,
      PalestrantesComponent,
      TituloComponent
   ],
  imports: [
    BrowserModule,
    BsDropdownModule.forRoot(), // forRoot faz com que o componente seja usado em qualquer lugar da aplicaçao
    BsDatepickerModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    ToastrModule.forRoot({
      timeOut: 10000,
      positionClass: 'toast-bottom-right',
      preventDuplicates: true,
    }),
    BrowserAnimationsModule, // componente que vai permitir a filtragem dos itens
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule
  ],
  providers: [
    EventoService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
