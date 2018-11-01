import { IBasicDetails } from "./IBasicDetails";
import { ILoginDetails } from "./ILoginDetails";
import { ISubscriptionDetails } from "./ISubscriptionDetails";

export interface IUser{
    BasicDetails:IBasicDetails;
    LoginDetails:ILoginDetails;
    SubscriptionDetails:ISubscriptionDetails;
}