import { UserService } from '../Services/UserService';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {FormGroup,FormControl,EmailValidator} from '@angular/forms'
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    public username = '';
    public password = '';
    public inputCheck = 1;

  constructor(private route:Router,private loginRegistrationService: UserService) { }
    tryLogin() {
        console.log('AtTryLogin');
        console.log(this.username, this.password);
        this.loginRegistrationService.usernameLogin = this.username;
        this.loginRegistrationService.passwordLogin = this.password;
        this.loginRegistrationService.LogUserIn().then(l => { this.checkIfUserLoggedIn(); }).then(e => { this.inputCheck = this.loginRegistrationService.user.id; });
    }
    checkIfUserLoggedIn() {
        if (this.loginRegistrationService.successfulLoginRegistration === true) {
            console.log('CheckIfUserLoggedIn?');
            this.route.navigate(['/']);
        }
    }
    ngOnInit() {

    }
}
