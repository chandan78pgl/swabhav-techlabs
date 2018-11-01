import { IUserDetailsDTO } from "../Services/IUserDetailsDTO";
import { ILoginDetailsDTO } from "./ILoginDetailsDTO";
import { ISubscriptionDetailsDTO } from "./ISubscriptionDetailsDTO";

export interface IUserDTO{
    UserDetails:IUserDetailsDTO;
    LoginDetails:ILoginDetailsDTO;
    SubscriptionDetails:ISubscriptionDetailsDTO;
}