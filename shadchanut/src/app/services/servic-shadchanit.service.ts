
import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';
import { LoginComponent } from './../components/login/login.component';
import { shadchanit } from 'src/class/shadchanit';

@Injectable({
  providedIn: 'root'
})
export class ServicShadchanitService {
  FindShadchanit(s:shadchanit)
  {

    return this.http.post<shadchanit>("http://localhost:55004/api/shadchanit/getShdchanit",s)
  }
  constructor(public http:HttpClient) { }
}
