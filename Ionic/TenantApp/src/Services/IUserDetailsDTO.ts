import { IContactDetailsDTO } from "../DTO/IContactDetailsDTO";
import { IAddressDetailsDTO } from "../DTO/IAddressDetailsDTO";

export interface IUserDetailsDTO{
    Name:string;
    Role:string;
    Currency:string;
    ShortName:string;
    WebUrl:string; 
    
    ContactDetails:IContactDetailsDTO[];
    AddressDetails:IAddressDetailsDTO[];
}
