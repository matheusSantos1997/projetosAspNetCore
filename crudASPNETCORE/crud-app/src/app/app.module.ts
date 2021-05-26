import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule } from 'ngx-bootstrap/modal';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { UsuarioComponent } from './usuario/usuario.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { UsuarioService } from './services/usuario.service';

@NgModule({
  declarations: [
    AppComponent,
      NavComponent,
      UsuarioComponent
   ],
  imports: [
    BrowserModule,
    BsDropdownModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ReactiveFormsModule
  ],
  providers: [
    UsuarioService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
