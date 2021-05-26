// node packages managers
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDropdownConfig, BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { TooltipConfig, TooltipModule } from 'ngx-bootstrap/tooltip';
import { ModalModule } from 'ngx-bootstrap/modal';
import { BsDatepickerConfig, BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { IConfig, NgxMaskModule } from 'ngx-mask';
import { NgxCurrencyModule } from 'ngx-currency';
import { TabsetConfig, TabsModule } from 'ngx-bootstrap/tabs';

// components, services, auth, pipes, etc
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TituloComponent } from './shared/titulo/titulo.component';
import { EventoComponent } from './evento/evento.component';
import { ContatosComponent } from './contatos/contatos.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NavComponent } from './nav/nav.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { UserComponent } from './user/user.component';
import { LoginComponent } from './user/login/login.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { EventoEditComponent } from './evento/eventoEdit/eventoEdit.component';
import { EventoService } from './services/evento.service';
import { AuthInterceptor } from './auth/auth.interceptor';
import { DateTimeFormatPipePipe } from './_helps/DateTimeFormatPipe.pipe';
import { AuthService } from './services/auth.service';

const maskConfig: () => Partial<IConfig> = () =>
{
  return {
    validation: false,
  };
};

@NgModule({
  declarations: [						
    AppComponent,
    EventoComponent,
      EventoEditComponent,
      NavComponent,
      DateTimeFormatPipePipe,
      DashboardComponent,
      ContatosComponent,
      PalestrantesComponent,
      TituloComponent,
      UserComponent,
      LoginComponent,
      RegistrationComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserModule,
    BsDropdownModule.forRoot(), // forRoot faz com que o componente seja usado em qualquer lugar da aplicaçao
    BsDatepickerModule.forRoot(),
    TooltipModule.forRoot(),
    ModalModule.forRoot(),
    ToastrModule.forRoot({
      timeOut: 2000,
      positionClass: 'toast-top-right',
      preventDuplicates: true,
    }),
    BrowserAnimationsModule, // componente que vai permitir a filtragem dos itens
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    NgxMaskModule.forRoot(maskConfig), // mascara de campo
    TabsModule.forRoot(),
    NgxCurrencyModule
  ],
  providers: [
    AuthService,
    BsDropdownConfig,
    BsDatepickerConfig,
    TooltipConfig,
    TabsetConfig,
    EventoService,
    {
       provide: HTTP_INTERCEPTORS,
       useClass: AuthInterceptor,
       multi: true // permite multiplas requisiçoes
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
