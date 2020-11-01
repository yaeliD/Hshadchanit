import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HashadchanitComponent } from './components/hashadchanit/hashadchanit.component';
import { RegisterComponent } from './components/register/register.component';
import { MatchesComponent } from './components/matches/matches.component';
import { MatchInProcessComponent } from './components/match-in-process/match-in-process.component';
import { HistoryOfMatchesComponent } from './components/history-of-matches/history-of-matches.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './components/login/login.component';



@NgModule({
  declarations: [
    AppComponent,
    HashadchanitComponent,
    RegisterComponent ,
    MatchesComponent ,
    MatchInProcessComponent ,
    HistoryOfMatchesComponent,
    LoginComponent
  ],
  imports: [

    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
