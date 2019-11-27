import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { User } from '../models/user';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';


export class UserService {
    constructor(private http: HttpClient, private route: Router) { }

    public loginSuccess: boolean;

    public user: User = { id: 0, username: '', password: '', role: 1 };
    public usernameLogin = '';
    public passwordLogin = '';

    private urlAPI = 'https://localhost:44327/api/user';

   /* public async LogUserIn(): Promise<any> {
        const config = { headers: new HttpHeaders().set('Content-Type', 'application/json') };
        return await this.http.get<number>
            (this.urlAPI + '?username=' + this.usernameLogin + '&password=' + this.passwordLogin)
            .toPromise().then(data => { this.user.id = data; console.log(this.user.id); })
            .catch((error: HttpErrorResponse) => { this.user.id = 0; })
            .then(d => { this.ChangeLoginStatus(); });
    }*/
}
