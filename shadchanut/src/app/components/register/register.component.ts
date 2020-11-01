import { community } from './../../../class/community';
import { Component, OnInit } from '@angular/core';
import {Router } from '@angular/router';
import {Candidates} from 'src/class/Candidates';
//import { ServicRegisterService } from './../../services/servic-register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  c:Candidates=new Candidates();
  arrAda: community;
  constructor(public router:Router) { } //public ser:ServicRegisterService,

  ngOnInit() {
  }
//   addCandidates()// פו הוספת מועמד חדש למערכת 
// {
//   this.ser.AddCandidatesr(this.c).subscribe(suc=>{
//     if(suc==false)alert("משתמש קיים/תפוס");
//     else
//     {alert("נרשמת בהצלחה!");}});

// }
//findAda(){this.ser.findAda(this.c).subscribe(suc=>this.r.CategoryRecipe=suc);}// פו המציגה את רשימת העדות

}



