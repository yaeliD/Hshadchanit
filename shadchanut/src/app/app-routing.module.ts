import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './components/register/register.component';
import { MatchesComponent } from './components/matches/matches.component';
import { LoginComponent } from './components/login/login.component';
import { HistoryOfMatchesComponent } from './components/history-of-matches/history-of-matches.component';
import { HashadchanitComponent } from './components/hashadchanit/hashadchanit.component';

const routes: Routes = [
  {path:"login",component:LoginComponent},
  {path:"Register",component:RegisterComponent}, 
  {path:"Matches",component:MatchesComponent},
  {path:"HistoryOfMatches",component:HistoryOfMatchesComponent},
  {path:"Hashadchanit",component:HashadchanitComponent},
  {path:"",redirectTo:"/Hashadchanit",pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
