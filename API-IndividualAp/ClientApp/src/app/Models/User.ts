export class User {
    id?: number;
    username: string;
    password: string;
    role: number;
}

export enum Roles {
    None = 0,
    Admin = 1,
    User = 2
}
