import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthGuard } from './auth/auth.guard';
import { ContatosComponent } from './contatos/contatos.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EventoComponent } from './evento/evento.component';
import { EventoEditComponent } from './evento/eventoEdit/eventoEdit.component';
import { PalestrantesComponent } from './palestrantes/palestrantes.component';
import { LoginComponent } from './user/login/login.component';
import { RegistrationComponent } from './user/registration/registration.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  { path: 'user', component: UserComponent,
    children: [
       { path: 'login' , component: LoginComponent },
       { path: 'registration', component: RegistrationComponent }
    ]
  },
  { path: 'evento', component: EventoComponent, canActivate: [AuthGuard] },
  { path: 'evento/:id/edit', component: EventoEditComponent, canActivate: [AuthGuard]},
  { path: 'palestrantes', component: PalestrantesComponent, canActivate: [AuthGuard] },
  { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'contatos', component: ContatosComponent, canActivate: [AuthGuard] },
  { path: '', redirectTo: 'dashboard', pathMatch: 'full'},
  { path: '**', redirectTo: 'dashboard', pathMatch: 'full'}
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
