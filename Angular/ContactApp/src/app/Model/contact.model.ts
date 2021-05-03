import { Address } from "./address.model";

export class Contact
{
    id?:string;
    name:string;
    mobileNumber:number;
    addresses:Address[];
    isFavorite:boolean;
}