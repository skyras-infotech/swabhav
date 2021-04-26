import { Contact } from "./contact.model";

export class User {
    id:string;
    tenantID:string;
    email: string;
    username: string;
    password: string;
    confirmPassword:string;
    companyName: string;
    companyStrength: number;
    role:string;
    contacts:Contact[]
}