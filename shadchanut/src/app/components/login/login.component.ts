import { ServicShadchanitService } from '../../services/servic-shadchanit.service';
import { shadchanit } from './../../../class/shadchanit';
import { Component, OnInit } from '@angular/core';
import {Router } from '@angular/router';



@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  s : shadchanit = new shadchanit;
  constructor(public router:Router ,public ser:ServicShadchanitService ) { }//

  ngOnInit() {
  }
  // loginShadchanit() בודק האם זה באמת השדכנית 
  // {
  //   this.ser.findShadchanit(this.s).subscribe(suc=>{
  //     //found 
  //     sessionStorage.setItem("userNow", this.s.username)
  //    if(suc==true){alert("ברוכים הבאים");this.router.navigate(["Matches"]); 
  //    sessionStorage.setItem('userNow',this.s.username);sessionStorage.setItem('user_password',this.s.password.toString());}
  //    //not found
  //     else if(suc==false){alert("אינך קיים במערכת");this.router.navigate(["Register"]);}
  //     //password not correct
  //     else{alert("סיסמה שגויה:");}
  //   })
  //     }
}



