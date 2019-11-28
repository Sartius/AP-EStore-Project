import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { User } from '../models/user';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable()
export class UserService {
    constructor(private http: HttpClient, private route: Router) { }
    public successfulLoginRegistration: boolean;

    public loginSuccess: boolean;

    public user: User = { id: 0, username: '', password: '', role: 1 };
    public usernameLogin = '';
    public passwordLogin = '';

    private urlAPI = 'http://localhost:53851/api/User/';

    public async LogUserIn() {
        console.log('AtUserService');
        const config = { headers: new HttpHeaders().set('Content-Type', 'application/json') };
        return await this.http.get<number>
            (this.urlAPI + '?username=' + this.usernameLogin + '&password=' + this.passwordLogin)
            .toPromise().then(data => { this.user.id = data; console.log(this.user.id); })
            .catch((error: HttpErrorResponse) => { this.user.id = 0; })
            .then(d => { this.changeLoginStatus(); });
    }
    public changeLoginStatus() {
        if (this.user.id > 0 && this.user.id !== undefined) {
            this.successfulLoginRegistration = true;
        }
    }
    public Logout() {
        this.user = { id: 0, username: '', password: '', role: 0 };
        this.successfulLoginRegistration = false;
        this.route.navigate(['/']);
    }
    public async ResisterUserAPI(regUser: User) {
        const headerHttp = {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            })
        };
        console.log(regUser);
        const user: User = { username: regUser.username, password: regUser.password, role: +regUser.role };
        return await this.http.post<number>(this.urlAPI, user, headerHttp)
            .toPromise()
            .then(data => { this.user.id = data; console.log(this.user.id); })
            .then(d => { this.changeLoginStatus(); })
    }
}
