import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { EscolasComponent } from './escolas/escolas.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { TurmasComponent } from './turmas/turmas.component';

const routes: Routes = [
  { path: '', redirectTo: 'escolas', pathMatch: 'full'},
  { path: 'escolas', component: EscolasComponent },
  { path: 'turmas', component: TurmasComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
