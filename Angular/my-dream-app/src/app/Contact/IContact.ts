import { IAddress } from "./IAddress";

export interface IContact
{
   name:string;
   mobileNumber:number;
   addresses:IAddress[];
}